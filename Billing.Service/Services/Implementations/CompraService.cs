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
    public class CompraService : BaseService<Compra, CompraDto>, ICompraService
    {
        public CompraService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public override async Task Save(CompraDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Compra>(model);

            var lastCompra = await dbSet.FirstOrDefaultAsync(x => x.ProdutoId == model.ProdutoId && x.IsActiva);

            if (lastCompra == null)
                return;

            var product = await mContext.Produto.FirstOrDefaultAsync(x => x.Id == model.ProdutoId);

            // The last compra is not active anymore
            lastCompra.IsActiva = false;

            // If there is any Quantidade at last compra, add it to the new one
            if (lastCompra.Quantidade > 0)
                dbModel.Quantidade += lastCompra.Quantidade;

            // Updating the PrecoUnitario field 
            product.PrecoUnitario = lastCompra.PrecoUnitarioVenda;

            dbModel.IsActiva = true;

            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task SaveAll(CompraDto[] models)
        {
            foreach (var model in models)
            {
                var dbModel = mapper.Map<Compra>(model);

                var lastCompra = await dbSet.FirstOrDefaultAsync(x => x.ProdutoId == model.ProdutoId && x.IsActiva);

                if (lastCompra != null) {
                    var product = await mContext.Produto.FirstOrDefaultAsync(x => x.Id == model.ProdutoId);

                    // The last compra is not active anymore
                    lastCompra.IsActiva = false;

                    dbModel.QuantidadeEntrada = dbModel.Quantidade;

                    // If there is any Quantidade at last compra, add it to the new one
                    if (lastCompra.Quantidade > 0)
                        dbModel.Quantidade += lastCompra.Quantidade;

                    // Updating the PrecoUnitario field 
                    product.PrecoUnitario = lastCompra.PrecoUnitarioVenda;
                }

                dbModel.IsActiva = true;

                // Adding the result to the local storage
                await dbSet.AddAsync(dbModel);
            }

            if (dbSet.Local.Any())
                await this.Commit();
        }
    }
}