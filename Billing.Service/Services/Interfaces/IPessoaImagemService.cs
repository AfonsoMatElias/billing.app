using System.Threading.Tasks;
using Billing.Service.Dto;
using Billing.Service.Models;
using Billing.Service.Services.Interfaces.Base;

namespace Billing.Service.Services.Interfaces
{
	public interface IPessoaImagemService : IBaseService<PessoaImagem, PessoaImagemDto>
	{
		Task RemoveMany(long[] filesToRemove);
	}
}