namespace Billing.Service.Authentication
{
    public class TokenResult
    {
        public string Token { get; set; }
        public string Type { get { return !string.IsNullOrEmpty(Token) ? "Bearer" : null; } }
    }
}
