using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Billing.Shared.Helpers
{
    public static class IoC
    {
        public static IServiceCollection ServiceProvider { get; set; }
        public static IConfiguration Configuration { get; set; }
    }
}