using Billing.Service.Pageable;

namespace Billing.App.Models
{
    public class PageableQueryParam : PageRange
    {
        public string OrderBy { get; set; }
    }
}