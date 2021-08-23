using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 465, DateTimeKind.Local).AddTicks(1291)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 439, DateTimeKind.Local).AddTicks(9571)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 458, DateTimeKind.Local).AddTicks(4445)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPessoa",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 460, DateTimeKind.Local).AddTicks(1133)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titulo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 461, DateTimeKind.Local).AddTicks(1820)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoriaId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 459, DateTimeKind.Local).AddTicks(2300)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProvinciaId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 446, DateTimeKind.Local).AddTicks(1899)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TipoPessoaId = table.Column<long>(type: "bigint", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    Identificacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimeiroNome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UltimoNome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TituloId = table.Column<long>(type: "bigint", nullable: true),
                    GeneroId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 450, DateTimeKind.Local).AddTicks(2961)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pessoa_TipoPessoa_TipoPessoaId",
                        column: x => x.TipoPessoaId,
                        principalTable: "TipoPessoa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pessoa_Titulo_TituloId",
                        column: x => x.TituloId,
                        principalTable: "Titulo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NomeSecundario = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 4056, nullable: true),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SubCategoriaId = table.Column<long>(type: "bigint", nullable: false),
                    IsPerecivel = table.Column<bool>(type: "bit", nullable: false),
                    IsStock = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 455, DateTimeKind.Local).AddTicks(3853)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_SubCategoria_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comuna",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MunicipioId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 476, DateTimeKind.Local).AddTicks(3086)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comuna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comuna_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Visibility = table.Column<bool>(type: "bit", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PessoaId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 490, DateTimeKind.Local).AddTicks(7116)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 462, DateTimeKind.Local).AddTicks(4039)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Pessoa_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FornecedorId = table.Column<long>(type: "bigint", nullable: false),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PrecoUnitarioCompra = table.Column<int>(type: "int", nullable: false),
                    PrecoUnitarioVenda = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiva = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 474, DateTimeKind.Local).AddTicks(6862)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Pessoa_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Compra_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProdutoImagem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 457, DateTimeKind.Local).AddTicks(7144)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoImagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoImagem_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Casa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ComunaId = table.Column<long>(type: "bigint", nullable: false),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 477, DateTimeKind.Local).AddTicks(6220)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Comuna_ComunaId",
                        column: x => x.ComunaId,
                        principalTable: "Comuna",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referencia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CriadorId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 466, DateTimeKind.Local).AddTicks(2304)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_Usuario_CriadorId",
                        column: x => x.CriadorId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendaId = table.Column<long>(type: "bigint", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 483, DateTimeKind.Local).AddTicks(1334)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VendaItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendaId = table.Column<long>(type: "bigint", nullable: false),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 463, DateTimeKind.Local).AddTicks(9122)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaItem_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VendaItem_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 468, DateTimeKind.Local).AddTicks(5307)),
                    Content = table.Column<string>(type: "varchar(4056)", unicode: false, maxLength: 4056, nullable: false),
                    Visibility = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioToId = table.Column<long>(type: "bigint", nullable: false),
                    UsuarioFromId = table.Column<long>(type: "bigint", nullable: false),
                    ChatId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessage_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessage_Usuario_UsuarioFromId",
                        column: x => x.UsuarioFromId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMessage_Usuario_UsuarioToId",
                        column: x => x.UsuarioToId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChatMessageAttachment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    ChatMessageId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 467, DateTimeKind.Local).AddTicks(2379)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessageAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessageAttachment_ChatMessage_ChatMessageId",
                        column: x => x.ChatMessageId,
                        principalTable: "ChatMessage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Estabelecimento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ComunaId = table.Column<long>(type: "bigint", nullable: false),
                    GerenteId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 479, DateTimeKind.Local).AddTicks(6102)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estabelecimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estabelecimento_Comuna_ComunaId",
                        column: x => x.ComunaId,
                        principalTable: "Comuna",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    EstabelecimentoId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 484, DateTimeKind.Local).AddTicks(4386)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Estabelecimento_EstabelecimentoId",
                        column: x => x.EstabelecimentoId,
                        principalTable: "Estabelecimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1L, "9cbaf4d4-b48d-43f4-a035-52a420c63081", "Admin", "ADMIN" },
                    { 2L, "9b09a220-e9ba-47de-96d3-98e3d8e3b981", "Gestor", "GESTOR" },
                    { 3L, "7aba98fa-364d-45a4-a95a-577a80409846", "Funcionario", "FUNCIONARIO" },
                    { 4L, "5cef6767-c484-44fb-b838-71af629b4c2b", "Fornecedor", "FORNECEDOR" },
                    { 5L, "feff9679-ea9c-423f-acc4-bdaf4a1722e1", "Vendedor", "VENDEDOR" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "Masculino", null, true },
                    { 2L, "Feminino", null, true }
                });

            migrationBuilder.InsertData(
                table: "TipoPessoa",
                columns: new[] { "Id", "Codigo", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "01", "Pessoa Singular", null, true },
                    { 2L, "02", "Pessoa Colectiva", null, true }
                });

            migrationBuilder.InsertData(
                table: "Titulo",
                columns: new[] { "Id", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "Sr.", null, true },
                    { 2L, "Sra.", null, true }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "AccessFailedCount", "Codigo", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PessoaId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName", "Visibility" },
                values: new object[] { 1L, 0, "Usuario0001", "f362854b-66b1-4c9e-9b3c-e3afc2d4204b", "Admin@Admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEIxu42E03IfphZwEDftyS2AXzhqbd49A8OJIFXWLBo6sPodpAMnQXYZdPhC/pwC+oQ==", null, null, true, "00000000-0000-0000-0000-000000000000", false, null, "Admin", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_CriadorId",
                table: "Chat",
                column: "CriadorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_ChatId",
                table: "ChatMessage",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_UsuarioFromId",
                table: "ChatMessage",
                column: "UsuarioFromId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_UsuarioToId",
                table: "ChatMessage",
                column: "UsuarioToId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessageAttachment_ChatMessageId",
                table: "ChatMessageAttachment",
                column: "ChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_FornecedorId",
                table: "Compra",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_ProdutoId",
                table: "Compra",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comuna_MunicipioId",
                table: "Comuna",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ComunaId",
                table: "Endereco",
                column: "ComunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estabelecimento_ComunaId",
                table: "Estabelecimento",
                column: "ComunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estabelecimento_GerenteId",
                table: "Estabelecimento",
                column: "GerenteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factura_VendaId",
                table: "Factura",
                column: "VendaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_EstabelecimentoId",
                table: "Funcionario",
                column: "EstabelecimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_UsuarioId",
                table: "Funcionario",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_ProvinciaId",
                table: "Municipio",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_GeneroId",
                table: "Pessoa",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TipoPessoaId",
                table: "Pessoa",
                column: "TipoPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TituloId",
                table: "Pessoa",
                column: "TituloId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_SubCategoriaId",
                table: "Produto",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoImagem_ProdutoId",
                table: "ProdutoImagem",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_CategoriaId",
                table: "SubCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Usuario",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PessoaId",
                table: "Usuario",
                column: "PessoaId",
                unique: true,
                filter: "[PessoaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuario",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItem_ProdutoId",
                table: "VendaItem",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItem_VendaId",
                table: "VendaItem",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimento_Funcionario_GerenteId",
                table: "Estabelecimento",
                column: "GerenteId",
                principalTable: "Funcionario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Usuario_UsuarioId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Comuna_Municipio_MunicipioId",
                table: "Comuna");

            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimento_Comuna_ComunaId",
                table: "Estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimento_Funcionario_GerenteId",
                table: "Estabelecimento");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChatMessageAttachment");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "ProdutoImagem");

            migrationBuilder.DropTable(
                name: "VendaItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "SubCategoria");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoPessoa");

            migrationBuilder.DropTable(
                name: "Titulo");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Comuna");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Estabelecimento");
        }
    }
}
