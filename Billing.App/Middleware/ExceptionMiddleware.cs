using System.Threading.Tasks;
using Billing.Service.Responses;
using Microsoft.AspNetCore.Http;

namespace Billing.App.Middleware
{
	public class ExceptionMiddleware
	{
		public readonly RequestDelegate request;

		public ExceptionMiddleware(RequestDelegate request)
		{
			this.request = request;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await this.request(context);
			}
			catch (AppException ex)
			{
				context.Response.StatusCode = 200;
				await context.Response.WriteAsJsonAsync(new Response
				{
					Errors = ex.Errors
				});
			}
		}
	}
}