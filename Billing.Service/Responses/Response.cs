using System.Linq;
using System.Collections.Generic;
using Billing.Service.Pageable;

namespace Billing.Service.Responses
{
	public class ResponseBase
	{
		public string Message { get; set; }
		public Pagination Pagination { get; set; }
		public IEnumerable<string> Errors { get; set; } = new List<string>();
		public bool Success { get { return Errors.Count() == 0; } }
	}

	public class Response<TModel> : ResponseBase where TModel : class
	{
		public TModel Data { get; set; }
	}

	public class Response : ResponseBase
	{
		public dynamic Data { get; set; }
	}
}
