using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class TipoProdutoConfig : IEntityTypeConfiguration<TipoProduto>
    {
        public void Configure(EntityTypeBuilder<TipoProduto> builder)
        {
            new BaseConfig().Configure(builder);
            
            builder.Property(e => e.Nome)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.Descricao)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.HasData(this.TableSeed());
        }

        internal TipoProduto[] TableSeed()
        {
            return (new[] {
                "P:Produto",
                "S:Serviço",
                "O:Outros",
                "IEC:Imposto Especial de Consumo",
                "E:N/A",
                "T:N/A",
            }).Select((item, index) => {
                var values = item.Split(':');
                return new TipoProduto {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Descricao = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}