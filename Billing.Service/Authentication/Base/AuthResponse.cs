using System.Collections.Generic;

namespace Billing.Service.Authentication
{
    public class AuthResponse
    {

        public TokenResult Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public bool Success { get { return Data != null ? true : false; } }
    }

    public class AuthResponse<T>
    {

        public T Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public bool Success { get { return Data != null ? true : false; } }
    }
}
