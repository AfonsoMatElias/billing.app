using System;
using System.Linq;
using Billing.Shared;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;

namespace Billing.Service.Services.Implementations
{
	public class GeneroService : BaseService<Genero, GeneroDto>, IGeneroService
	{
		public GeneroService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }
	}
}