using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Shared.Helpers;
using Billing.Service.Responses;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Authentication
{
    public class Auth : IAuth
    {
        #region Private Fields
        private readonly DataContext context;
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;
        #endregion

        #region Default Constructor
        public Auth(UserManager<Usuario> mUser,
                    SignInManager<Usuario> mSignIn,
                    DataContext context)
        {
            this.userManager = mUser;
            this.signInManager = mSignIn;
            this.context = context;
        }
        #endregion

        public async Task<AuthResponse> SignIn(SignInModel model)
        {
            var isEmail = false;
            // Setting the default value
            var userName = model.User;
            var password = model.Password ?? "";
            // Checking if it is an email
            if (model.User.Contains("@"))
            {
                // Finding the user having the passed email
                var _user_ = await userManager.FindByEmailAsync(userName);
                // Checking if it was not found
                if (_user_ == null)
                    return new AuthResponse
                    {
                        Errors = new List<string> { "Email ou Palavra-Passe inválida." }
                    };

                // Setting the user name
                userName = _user_.UserName;
                isEmail = true;
            }

            // Signing in
            var result = await signInManager.PasswordSignInAsync(userName, model.Password, true, false);
            // Checking if he was found
            if (result.IsLockedOut)
                return new AuthResponse
                {
                    Errors = new List<string> { "A conta foi bloqueada!" }
                };

            // Checking if he was found
            if (!result.Succeeded)
                return new AuthResponse
                {
                    Errors = new List<string> { "Email ou Palavra-Passe inválida." }
                };

            // Getting the user
            var user = isEmail ? await userManager.FindByEmailAsync(model.User) : await userManager.FindByNameAsync(model.User);
            // Getting all registed claims
            var claims = await userManager.GetClaimsAsync(user);
            // Getting all the roles
            var roles = await userManager.GetRolesAsync(user);

            // Adding the roles to the claims
            foreach (var item in roles)
                claims.Add(new Claim("role", item));

            // Generating and Returning the token
            return new AuthResponse
            {
                Data = new TokenResult
                {
                    Token = new TokenHandler(new Param
                    {
                        Id = user.Id.ToString(),
                        Name = user.UserName,
                        Email = user.Email,
                    }).Generate(claims.ToList())
                }
            };
        }

        public async Task<AuthResponse> SignUp(SignUpModel model, string password, bool isAdmin = false)
        {
            // Checking if there is a user having this email
            var user = await userManager.FindByEmailAsync(model.Email);

            // Checking if he was found
            if (user != null)
                return new AuthResponse
                {
                    Errors = new List<string> { "Já existe um usuário com este endereço de email" }
                };
            
            var count = await context.Usuario.LongCountAsync();

            // Creating the user
            var result = await userManager.CreateAsync(new Usuario
            {
                Email = model.Email,
                Codigo = (++count).ToString().PadLeft(10, '0'), 
                UserName = String.Join(".", new [] { 
                    model.PrimeiroNome, 
                    model.UltimoNome ?? Guid.NewGuid().ToString().Split("-")[0] 
                }),
                Pessoa = new Pessoa
                {
                    PrimeiroNome = model.PrimeiroNome,
                    UltimoNome = model.UltimoNome,
                    Identificacao = model.Identificacao,
                    DataNascimento = model.DataNascimento,
                    TituloId = model.TituloId,
                    GeneroId = model.GeneroId,
                },
                Funcionario = new Funcionario {
                    EstabelecimentoId = model.EstabelecimentoId
                }
            }, password);

            // Checking if anything went wrong
            if (!result.Succeeded)
                return new AuthResponse
                {
                    Errors = result.Errors.Select(error =>
                    {
                        return $"Code: { error.Code }; Description: { error.Description }";
                    }).ToList()
                };

            // Getting the registed user
            user = await userManager.FindByEmailAsync(model.Email);

            var claims = new List<Claim>();
            var roles = model.Roles != null ? model.Roles.ToList() : new List<string>();

            // Adding the specific roles
            foreach (var role in roles)
                await userManager.AddToRoleAsync(user, role);

            // Generating and Returning the token
            return new AuthResponse
            {
                Data = new TokenResult
                {
                    Token = new TokenHandler(new Param
                    {
                        Id = user.Id.ToString(),
                        Name = user.UserName,
                        Email = user.Email,
                    }).Generate(roles.Select(role => new Claim("role", role)).ToList())
                }
            };
        }

        public async Task<AuthResponse> SignOut(Guid id)
        {
            await signInManager.SignOutAsync();
            return new AuthResponse
            {
                Data = new TokenResult
                {
                    Token = null
                }
            };
        }

        public async Task<AuthResponse<AccountModel>> Account(string id)
        {
            try
            {
                // Finding the user having the id provided
                var user = await userManager.FindByIdAsync(id);

                // If the user was not found throw an exception
                if (user == null) throw new AppException("Conta não encontrada!", true);

                var pessoa = await context.Pessoa.Include(x => x.Usuario.Funcionario)
                                .FirstOrDefaultAsync(x => x.Id == user.PessoaId);

                var funcionario = pessoa?.Usuario.Funcionario;
                if (pessoa != null)
                    pessoa.Usuario = null;

                // Setting the user
                return new AuthResponse<AccountModel>
                {
                    Data = new AccountModel
                    {
                        Id = user.Id.ToString(),
                        Nome = pessoa?.PrimeiroNome != null ? $"{pessoa.PrimeiroNome} {pessoa.UltimoNome}" : user.UserName,
                        UserName = user.UserName,
                        Email = user.Email,
                        User = pessoa,
                        HasEstabelecimento = funcionario?.EstabelecimentoId != null,
                        EstabelecimentoId = funcionario?.EstabelecimentoId
                    }
                };
            }
            catch (AppException ex)
            {
                return new AuthResponse<AccountModel>
                {
                    Errors = ex.Errors
                };
            }
        }

        public async Task<Response> ChangePassword(string id, string current, string @new)
        {
            var errors = new List<string>();
            try
            {
                // Finding the user
                var user = await userManager.FindByIdAsync(id);
                if (user == null)
                    throw new AppException("Usuário não encontrado.", true);

                // Changing th password
                var result = await userManager.ChangePasswordAsync(user, current, @new);

                if (!result.Succeeded)
                    throw new AppException("As palavras passes não coencidem.", true);

                return new Response
                {
                    Message = "Palavra-passe actualizada"
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors
                };
            }

        }

        public async Task<Response> ChangeRoles(string id, string[] roles)
        {
            try
            {
                var user = await userManager.FindByIdAsync(id);
                // Getting the roles
                var userRoles = await userManager.GetRolesAsync(user);
                // Removing all the roles
                await userManager.RemoveFromRolesAsync(user, userRoles);

                // Adding the current roles
                await userManager.AddToRolesAsync(user, roles);

                return new Response
                {
                    Data = roles
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors
                };
            }
        }

        public async Task<Response> GetAdminUser()
        {
            var admin = await userManager.FindByEmailAsync(IoC.Configuration["App:AdminEmail"]);
            return new Response
            {
                Errors = admin == null ? new string[] { "Algo correu mal." } : new string[] { }
            };
        }

        public async Task<Response> UserRoles(string id)
        {
            try
            {
                var user = await userManager.FindByIdAsync(id);
                if (user == null) throw new AppException("Usuário não encontrado.", true);
                return new Response
                {
                    Data = (await userManager.GetRolesAsync(user))?.ToList(),
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors
                };
            }

        }

        public async Task<Response> ChangeUserInfo(string id, SignUpModel model)
        {
            await Task.Delay(0);
            return new Response { };
        }

        public async Task<Response> UserInRole(string role)
        {
            try
            {
                var users = await userManager.GetUsersInRoleAsync(role);

                return new Response
                {
                    Data = users.Select(x =>
                    {
                        return x.Id;
                    }).ToList()
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors
                };
            }

        }
    }
}