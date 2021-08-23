using System.Linq;
using AutoMapper;
using Billing.Service.Dto;
using Billing.Service.Models;

namespace Billing.App.Mapping
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Categoria, CategoriaDto>()
                .ForPath(dst => dst.SubCategorias,
                    xps => xps.MapFrom(src => src.SubCategorias.Select(x => new SubCategoria
                    {
                        Id = x.Id,
                        CategoriaId = x.CategoriaId,
                        CreatedAt = x.CreatedAt,
                        Visibility = x.Visibility,
                        UpdatedAt = x.UpdatedAt,
                        Nome = x.Nome,
                    })));
            CreateMap<CategoriaDto, Categoria>();

            CreateMap<Chat, ChatDto>();
            CreateMap<ChatDto, Chat>();

            CreateMap<ChatMessageAttachment, ChatMessageAttachmentDto>();
            CreateMap<ChatMessageAttachmentDto, ChatMessageAttachment>();

            CreateMap<ChatMessage, ChatMessageDto>();
            CreateMap<ChatMessageDto, ChatMessage>();

            CreateMap<Compra, CompraDto>()
                .ForPath(dst => dst.Produto, xps => xps.MapFrom(src => new Produto {
                    Id = src.Produto.Id,
                    Codigo = src.Produto.Codigo,
                    CreatedAt = src.Produto.CreatedAt,
                    Descricao = src.Produto.Descricao,
                    IsPerecivel = src.Produto.IsPerecivel,
                    IsStock = src.Produto.IsStock,
                    Nome = src.Produto.Nome,
                    NomeSecundario = src.Produto.NomeSecundario,
                    PrecoUnitario = src.Produto.PrecoUnitario,
                    ProdutoImagens = src.Produto.ProdutoImagens,
                    SubCategoria = src.Produto.SubCategoria,
                    UpdatedAt = src.Produto.UpdatedAt,
                    SubCategoriaId = src.Produto.SubCategoriaId,
                    Visibility = src.Produto.Visibility
                }));
            CreateMap<CompraDto, Compra>();

            CreateMap<Comuna, ComunaDto>()
                .ForPath(dst => dst.Municipio, xps => xps.MapFrom(src => src.Municipio));
            CreateMap<ComunaDto, Comuna>();

            CreateMap<Endereco, EnderecoDto>();
            CreateMap<EnderecoDto, Endereco>();

            CreateMap<Entidade, EntidadeDto>()
                .ForPath(dst => dst.Pessoa, xps => xps.MapFrom(src => src.Pessoa))
                .ForPath(dst => dst.TipoEntidade, xps => xps.MapFrom(src => new TipoEntidade
                {
                    Id = src.TipoEntidade.Id,
                    Nome = src.TipoEntidade.Nome,
                    CreatedAt = src.TipoEntidade.CreatedAt,
                    UpdatedAt = src.TipoEntidade.UpdatedAt,
                    Visibility = src.TipoEntidade.Visibility,
                }))
                .ForPath(dst => dst.TipoPessoa, xps => xps.MapFrom(src => new TipoPessoa
                {
                    Id = src.TipoPessoa.Id,
                    Nome = src.TipoPessoa.Nome,
                    CreatedAt = src.TipoPessoa.CreatedAt,
                    UpdatedAt = src.TipoPessoa.UpdatedAt,
                    Visibility = src.TipoPessoa.Visibility,
                }));
            CreateMap<EntidadeDto, Entidade>();

            CreateMap<Estabelecimento, EstabelecimentoDto>()
                .ForPath(dst => dst.Gerente, xps => xps.MapFrom(src => src.Gerente))
                .ForPath(dst => dst.Comuna, xps => xps.MapFrom(src => src.Comuna));
            CreateMap<EstabelecimentoDto, Estabelecimento>();

            CreateMap<Factura, FacturaDto>();
            CreateMap<FacturaDto, Factura>();

            CreateMap<Funcionario, FuncionarioDto>()
                .ForPath(dst => dst.Usuario, xps => xps.MapFrom(src => src.Usuario));
            CreateMap<FuncionarioDto, Funcionario>();

            CreateMap<Genero, GeneroDto>();
            CreateMap<GeneroDto, Genero>();

            CreateMap<License, LicenseDto>();
            CreateMap<LicenseDto, License>();

            CreateMap<Municipio, MunicipioDto>()
                .ForPath(dst => dst.Provincia, xps => xps.MapFrom(src => src.Provincia))
                .ForPath(dst => dst.Comunas, xps => xps.MapFrom(src => src.Comunas));

            CreateMap<MunicipioDto, Municipio>();

            CreateMap<Pessoa, PessoaDto>()
                .ForPath(dst => dst.Genero, xps => xps.MapFrom(src => new Genero
                {
                    Id = src.Genero.Id,
                    Nome = src.Genero.Nome,
                    CreatedAt = src.Genero.CreatedAt,
                    UpdatedAt = src.Genero.UpdatedAt,
                    Visibility = src.Genero.Visibility,
                }))
                .ForPath(dst => dst.Titulo, xps => xps.MapFrom(src => new Titulo
                {
                    Id = src.Titulo.Id,
                    Nome = src.Titulo.Nome,
                    CreatedAt = src.Titulo.CreatedAt,
                    UpdatedAt = src.Titulo.UpdatedAt,
                    Visibility = src.Titulo.Visibility,
                }));

            CreateMap<PessoaDto, Pessoa>();

            CreateMap<Produto, ProdutoDto>()
                .ForPath(dst => dst.ProdutoImagens, src => src.MapFrom(x => x.ProdutoImagens.Select(y => new ProdutoImagem
                {
                    Id = y.Id,
                    ImageUrl = y.ImageUrl,
                })))
                .ForPath(dst => dst.SubCategoria, src => src.MapFrom(x => new SubCategoria
                {
                    Id = x.SubCategoria.Id,
                    Nome = x.SubCategoria.Nome,
                    Categoria = x.SubCategoria.Categoria != null ? new Categoria
                    {
                        Id = x.SubCategoria.Categoria.Id,
                        Nome = x.SubCategoria.Categoria.Nome
                    } : null
                }))
                .ForPath(dst => dst.Compras, src => src.MapFrom(x => x.Compras.Select(y => new Compra
                {
                    Id = y.Id,
                    CreatedAt = y.CreatedAt,
                    UpdatedAt = y.UpdatedAt,
                    DataEntrada = y.DataEntrada,
                    DataValidade = y.DataValidade,
                    EstabelecimentoId = y.EstabelecimentoId,
                    FornecedorId = y.FornecedorId,
                    IsActiva = y.IsActiva,
                    PrecoUnitarioCompra = y.PrecoUnitarioCompra,
                    PrecoUnitarioVenda = y.PrecoUnitarioVenda,
                    ProdutoId = y.ProdutoId,
                    Quantidade = y.Quantidade,
                })));
            CreateMap<ProdutoDto, Produto>();

            CreateMap<ProdutoImagem, ProdutoImagemDto>();
            CreateMap<ProdutoImagemDto, ProdutoImagem>();

            CreateMap<Provincia, ProvinciaDto>()
                .ForPath(dst => dst.Municipios, xps => xps.MapFrom(src => src.Municipios));
            CreateMap<ProvinciaDto, Provincia>();

            CreateMap<SubCategoria, SubCategoriaDto>();
            CreateMap<SubCategoriaDto, SubCategoria>();

            CreateMap<TipoPessoa, TipoPessoaDto>();
            CreateMap<TipoPessoaDto, TipoPessoa>();

            CreateMap<TipoEntidade, TipoEntidadeDto>();
            CreateMap<TipoEntidadeDto, TipoEntidade>();

            CreateMap<Titulo, TituloDto>();
            CreateMap<TituloDto, Titulo>();

            CreateMap<Usuario, UsuarioDto>()
                .ForPath(dst => dst.Pessoa, xps => xps.MapFrom(src => src.Pessoa));
            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Venda, VendaDto>();
            CreateMap<VendaDto, Venda>();

            CreateMap<VendaItem, VendaItemDto>();
            CreateMap<VendaItemDto, VendaItem>();
        }
    }
}