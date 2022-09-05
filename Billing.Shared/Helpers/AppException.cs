using System;
using System.Collections.Generic;

/// <summary>
/// Exception class utilizada para poder controllar quais messagens de erro podem e ser retornadas 
/// </summary>
public class AppException : Exception
{
	public string Msg { get; set; }
	public int StatusCode { get; set; }
	public List<String> Errors { get; set; }

	public AppException(string msg, bool @return = false, int statusCode = 200) : base(msg)
	{

		Msg = @return ? msg : "";

		var message = $"Info: {this.Msg}. {this.Message} {this.InnerException?.Message}".Trim();

		System.Diagnostics.Debugger.Log(1, "Server Error: ", message);

		this.StatusCode = statusCode;
		this.Errors = new List<string> {
				string.IsNullOrEmpty(this.Msg) ? "Algum erro ocorreu no servidor. Por favor contacte o suporte tecnico." : this.Msg
			};
	}
}