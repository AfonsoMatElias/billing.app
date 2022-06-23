using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Billing.App.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetUserId(this HttpContext context)
        {
            var claim = context.User?.Claims.FirstOrDefault(x => x.Type == "id");
            if (claim == null) return null;
            if (string.IsNullOrEmpty(claim.Value)) return null;
            return claim.Value;
        }

        public static string GetKey(this HttpContext context, string key)
        {
            var claim = context.User?.Claims.FirstOrDefault(x => x.Type == key);
            if (claim == null) return null;
            if (string.IsNullOrEmpty(claim.Value)) return null;
            return claim.Value;
        }
    }
}