using System;
using System.Threading.Tasks;
using Billing.Service.Responses;

namespace Billing.Service.Authentication
{
    public interface IAuth
    {
        /// <summary>
        /// Allow a user to sign in and get a jwt token to authorize him
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        Task<AuthResponse> SignIn(SignInModel model);

        /// <summary>
        /// Allow the user creation and also return a jwt token to authorize him
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        Task<AuthResponse> SignUp(SignUpModel model, string password, bool isAdmin = false);

        Task<AuthResponse> SignOut(Guid id);

        Task<AuthResponse<AccountModel>> Account(string id);

        Task<Response> ChangePassword(string id, string current, string @new);

        Task<Response> GetAdminUser();
        
        Task<Response> UserRoles(string id);

        Task<Response> ChangeUserInfo(string id, SignUpModel model);
        
        Task<Response> ChangeRoles(string id, string[] roles);

        Task<Response> UserInRole(string role);
    }
}
