using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Collections.Generic;
using Billing.Shared.Helpers;

namespace Billing.Service.Authentication
{
    public class Param
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class TokenHandler
    {
        #region Private Fields
        private readonly Param mObj;
        #endregion

        #region Default Constructor
        public TokenHandler(Param obj)
        {
            this.mObj = obj;
        }
        #endregion

        public string Generate(List<Claim> _claims)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(JwtRegisteredClaimNames.Email, mObj.Email),
                new Claim("name", mObj.Name),
                new Claim("id", mObj.Id)
            };

            claims.AddRange(_claims);

            // Creating the credentials
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(IoC.Configuration["Jwt:SecretKey"])),
                    SecurityAlgorithms.HmacSha256);

            // Creating the jwt token
            var token = new JwtSecurityToken(
                issuer: IoC.Configuration["Jwt:Issuer"],
                audience: IoC.Configuration["Jwt:Audience"],
                claims: claims,
                signingCredentials: credentials,
                expires: DateTime.Now.AddMonths(3));

            // Generating the token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}