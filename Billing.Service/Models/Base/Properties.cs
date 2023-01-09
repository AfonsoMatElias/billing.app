using System;

namespace Billing.Service.Models.Base
{
	public class Properties
	{
		public long Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public bool? Visibility { get; set; } = true;
	}
}