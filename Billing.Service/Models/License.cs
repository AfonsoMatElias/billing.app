using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class License : Base.Properties
    {
        public Guid Codigo { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}