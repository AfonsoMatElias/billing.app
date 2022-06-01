using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class License
    {
        public long Id { get; set; }
        public Guid Codigo { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}