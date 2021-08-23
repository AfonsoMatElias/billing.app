using System.Reflection;
using Billing.Service.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Data
{
    public class DataContext : IdentityDbContext<Usuario, IdentityRole<long>, long>
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<ChatMessage> ChatMessage { get; set; }
        public DbSet<ChatMessageAttachment> ChatMessageAttachment { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Comuna> Comuna { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoImagem> ProdutoImagem { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<TipoContacto> TipoContacto { get; set; }
        public DbSet<TipoEntidade> TipoEntidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaItem> VendaItem { get; set; }
        public DbSet<Titulo> Titulo { get; set; }
        public DbSet<TipoPessoa> TipoPessoa { get; set; }

        public DataContext() {}

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}