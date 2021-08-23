using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class LicenseDto
    {
        public long Id { get; set; }
        public Guid Codigo { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
