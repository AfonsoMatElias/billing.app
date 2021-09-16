using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class TableRestruturation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Comuna_ComunaId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimento_Comuna_ComunaId",
                table: "Estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_TipoEntidade_TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "Comuna");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ComunaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ComunaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "IsPrincipal",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "ComunaId",
                table: "Estabelecimento",
                newName: "EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Estabelecimento_ComunaId",
                table: "Estabelecimento",
                newName: "IX_Estabelecimento_EnderecoId");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Endereco",
                newName: "PaisId");

            migrationBuilder.RenameColumn(
                name: "Casa",
                table: "Endereco",
                newName: "Porta");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                newName: "IX_Endereco_PaisId");

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "VendaItem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 625, DateTimeKind.Local).AddTicks(5555),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 633, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Venda",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<long>(
                name: "TipoVendaId",
                table: "Venda",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 624, DateTimeKind.Local).AddTicks(1653),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 629, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.AddColumn<long>(
                name: "FormaPagamentoId",
                table: "Venda",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 643, DateTimeKind.Local).AddTicks(4099),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 676, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Titulo",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 623, DateTimeKind.Local).AddTicks(527),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 626, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoVenda",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 622, DateTimeKind.Local).AddTicks(4261),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 624, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoPessoa",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 621, DateTimeKind.Local).AddTicks(7448),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 620, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoFactura",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 621, DateTimeKind.Local).AddTicks(874),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 617, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoEntidade",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 620, DateTimeKind.Local).AddTicks(3142),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 616, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoContacto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoContacto",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 619, DateTimeKind.Local).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "TipoContacto",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "SubCategoria",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 619, DateTimeKind.Local).AddTicks(917),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 614, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoMotivoIsencao",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 618, DateTimeKind.Local).AddTicks(3640),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 612, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoImagem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 617, DateTimeKind.Local).AddTicks(5571),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 609, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 616, DateTimeKind.Local).AddTicks(1112),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 605, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 614, DateTimeKind.Local).AddTicks(6080),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 600, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "MotivoIsencao",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "MotivoIsencao",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MotivoIsencao",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 613, DateTimeKind.Local).AddTicks(6706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Classificacao",
                table: "MotivoIsencao",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Genero",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 610, DateTimeKind.Local).AddTicks(8972),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 589, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Funcionario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 639, DateTimeKind.Local).AddTicks(4227),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 665, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Factura",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 638, DateTimeKind.Local).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 663, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Estabelecimento",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 635, DateTimeKind.Local).AddTicks(4870),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 658, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Entidade",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 600, DateTimeKind.Local).AddTicks(5066),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 564, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresa",
                table: "Entidade",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaContactoEmpresa",
                table: "Entidade",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 634, DateTimeKind.Local).AddTicks(5396),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 655, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Endereco",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detalhado",
                table: "Endereco",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Contacto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 633, DateTimeKind.Local).AddTicks(6900),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 653, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Compra",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 632, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 648, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessageAttachment",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 627, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 638, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessage",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 628, DateTimeKind.Local).AddTicks(6857),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 640, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "ChatMessage",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Chat",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 627, DateTimeKind.Local).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 636, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Categoria",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 626, DateTimeKind.Local).AddTicks(3219),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 635, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 638, DateTimeKind.Local).AddTicks(6861)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 652, DateTimeKind.Local).AddTicks(3547)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.InsertData(
                table: "TipoContacto",
                columns: new[] { "Id", "Codigo", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "01", "Telefone", null },
                    { 2L, "02", "Email", null },
                    { 3L, "03", "Fax", null }
                });

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoFactura",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoFactura",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoVenda",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "TipoVenda",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "Titulo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "Titulo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: null);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b47499e-6535-47e5-9ee0-408088fc566c", "AQAAAAEAACcQAAAAEFIb6VmnKmlvpP7783nl66q2vgFf9BM7/jBzlpp0pl9CGdLcJir6Z8MHBq/TggoCfw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_FormaPagamentoId",
                table: "Venda",
                column: "FormaPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pais_PaisId",
                table: "Endereco",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimento_Endereco_EnderecoId",
                table: "Estabelecimento",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_FormaPagamento_FormaPagamentoId",
                table: "Venda",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda",
                column: "TipoVendaId",
                principalTable: "TipoVenda",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pais_PaisId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimento_Endereco_EnderecoId",
                table: "Estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_FormaPagamento_FormaPagamentoId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropIndex(
                name: "IX_Venda_FormaPagamentoId",
                table: "Venda");

            migrationBuilder.DeleteData(
                table: "TipoContacto",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TipoContacto",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TipoContacto",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "FormaPagamentoId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "NomeEmpresa",
                table: "Entidade");

            migrationBuilder.DropColumn(
                name: "NomePessoaContactoEmpresa",
                table: "Entidade");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Detalhado",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Estabelecimento",
                newName: "ComunaId");

            migrationBuilder.RenameIndex(
                name: "IX_Estabelecimento_EnderecoId",
                table: "Estabelecimento",
                newName: "IX_Estabelecimento_ComunaId");

            migrationBuilder.RenameColumn(
                name: "Porta",
                table: "Endereco",
                newName: "Casa");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                table: "Endereco",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PaisId",
                table: "Endereco",
                newName: "IX_Endereco_PessoaId");

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "VendaItem",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 633, DateTimeKind.Local).AddTicks(3646),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 625, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Venda",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "TipoVendaId",
                table: "Venda",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 629, DateTimeKind.Local).AddTicks(8387),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 624, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Usuario",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 676, DateTimeKind.Local).AddTicks(7286),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 643, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Titulo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 626, DateTimeKind.Local).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 623, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoVenda",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 624, DateTimeKind.Local).AddTicks(5804),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 622, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoPessoa",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 620, DateTimeKind.Local).AddTicks(2806),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 621, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoFactura",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 617, DateTimeKind.Local).AddTicks(9521),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 621, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoEntidade",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 616, DateTimeKind.Local).AddTicks(1100),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 620, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoContacto",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TipoContacto",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoContacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 619, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "TipoContacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "SubCategoria",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 614, DateTimeKind.Local).AddTicks(6577),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 619, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoMotivoIsencao",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 612, DateTimeKind.Local).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 618, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoImagem",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 609, DateTimeKind.Local).AddTicks(6879),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 617, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Produto",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 605, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 616, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 600, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 614, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.AddColumn<long>(
                name: "TipoEntidadeId",
                table: "Pessoa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "MotivoIsencao",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MotivoIsencao",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "MotivoIsencao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "MotivoIsencao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 613, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.AlterColumn<string>(
                name: "Classificacao",
                table: "MotivoIsencao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Genero",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 589, DateTimeKind.Local).AddTicks(2380),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 610, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Funcionario",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 665, DateTimeKind.Local).AddTicks(4925),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 639, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Factura",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 663, DateTimeKind.Local).AddTicks(2898),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 638, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Estabelecimento",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 658, DateTimeKind.Local).AddTicks(2010),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 635, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Entidade",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 564, DateTimeKind.Local).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 600, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Endereco",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 655, DateTimeKind.Local).AddTicks(7725),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 634, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "ComunaId",
                table: "Endereco",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrincipal",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Contacto",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 653, DateTimeKind.Local).AddTicks(5233),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 633, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Compra",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 648, DateTimeKind.Local).AddTicks(8750),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 632, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessageAttachment",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 638, DateTimeKind.Local).AddTicks(3179),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 627, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessage",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 640, DateTimeKind.Local).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 628, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "ChatMessage",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Chat",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 636, DateTimeKind.Local).AddTicks(8044),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 627, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Categoria",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 635, DateTimeKind.Local).AddTicks(1596),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 15, 50, 626, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 613, DateTimeKind.Local).AddTicks(4431)),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 596, DateTimeKind.Local).AddTicks(3412)),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProvinciaId = table.Column<long>(type: "bigint", nullable: false),
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
                name: "Comuna",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 8, 12, 46, 58, 651, DateTimeKind.Local).AddTicks(7760)),
                    MunicipioId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoFactura",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoFactura",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoVenda",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "TipoVenda",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "Titulo",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "Titulo",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Visibility",
                value: true);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1e6e3dd-8713-47ee-8207-a00511474561", "AQAAAAEAACcQAAAAEJDJYQ5a8gmhmnA4alO/hryy2NlNtbPv4058Q7IE3sFbHzdjXXRreliQfS9QMbPD4A==" });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa",
                column: "TipoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ComunaId",
                table: "Endereco",
                column: "ComunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comuna_MunicipioId",
                table: "Comuna",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_ProvinciaId",
                table: "Municipio",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Comuna_ComunaId",
                table: "Endereco",
                column: "ComunaId",
                principalTable: "Comuna",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimento_Comuna_ComunaId",
                table: "Estabelecimento",
                column: "ComunaId",
                principalTable: "Comuna",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_TipoEntidade_TipoEntidadeId",
                table: "Pessoa",
                column: "TipoEntidadeId",
                principalTable: "TipoEntidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda",
                column: "TipoVendaId",
                principalTable: "TipoVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
