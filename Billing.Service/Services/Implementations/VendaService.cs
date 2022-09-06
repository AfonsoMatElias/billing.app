using System;
using System.Linq;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using System.Threading.Tasks;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Billing.Service.Services.Implementations
{
    public class VendaService : BaseService<Venda, VendaDto>, IVendaService
    {
        public VendaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public override async Task Save(VendaDto model, bool isCommit = true)
        {
            if (model.Factura == null)
                throw new AppException($"Modelo inválido, dados da factura em falta.", true);

            var tipoVenda = await mContext.TipoVenda.FirstOrDefaultAsync(x => x.Codigo == model.CodigoTipoVenda);
            var tipoFactura = await mContext.TipoFactura.FirstOrDefaultAsync(x => x.Codigo == model.Factura.CodigoTipoFactura);

            if (tipoVenda == null)
                throw new AppException($"Codigo de Tipo de Venda Inválido.", true);

            if (tipoFactura == null)
                throw new AppException($"Codigo de Tipo de Factura Inválido.", true);

            var dbModel = mapper.Map<Venda>(model);

            foreach (var item in dbModel.VendaItens)
            {
                var lastCompra = await mContext.Compra
                                               .Include(x => x.Produto)
                                               .FirstOrDefaultAsync(
                                                    x => x.ProdutoId == item.ProdutoId && x.IsActiva
                                                );

                var stock = lastCompra.Quantidade;

                if ((stock - item.Quantidade) < 0)
                    throw new AppException($"Produto `{lastCompra.Produto.Nome}` tem o stock insuficiente para reduzir {item.Quantidade} itens", true);

                lastCompra.Quantidade -= item.Quantidade;
            }

            var uIndentifier = Guid.NewGuid().ToString().Split("-").First();

            // Generating the Selling Reference
            dbModel.Referencia = $"Ref:{uIndentifier}-{ DateTime.Now.ToString("yyMMdd") }";

            // Adding the Factura
            dbModel.Factura = new Factura
            {
                Referencia = dbModel.Referencia,
                TipoFacturaId = tipoFactura.Id
            };

            dbModel.TipoVendaId = tipoVenda.Id;

            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }
    }
}