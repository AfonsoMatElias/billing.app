namespace Billing.App.Models
{
    public class PageableQueryParam
    {
        public int? Page { get; set; }
        public int? Size { get; set; }
        public string OrderBy { get; set; }
    }
}