using System;

namespace Billing.Service.Dto.Base
{
    public class Properties
    {
        public long Id { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public bool Visibility { get; set; } = true;
    }
}