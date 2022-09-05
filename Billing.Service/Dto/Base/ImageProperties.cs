using System;

namespace Billing.Service.Dto.Base
{
	public class ImageProperties : Properties
	{
		public string Name { get; set; }
		public string UniqueName { get; set; }
		public string Extension { get; set; }
		public byte[] Content { get; set; }
	}
}