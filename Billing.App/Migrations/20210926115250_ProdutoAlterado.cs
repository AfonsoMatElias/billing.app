using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class ProdutoAlterado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 504, DateTimeKind.Local).AddTicks(7202),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 355, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 502, DateTimeKind.Local).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 352, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 444, DateTimeKind.Local).AddTicks(1464),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 312, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 500, DateTimeKind.Local).AddTicks(2073),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 350, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 499, DateTimeKind.Local).AddTicks(269),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 349, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 497, DateTimeKind.Local).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 347, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 496, DateTimeKind.Local).AddTicks(4013),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 346, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 495, DateTimeKind.Local).AddTicks(1132),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 344, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 494, DateTimeKind.Local).AddTicks(1002),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 343, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 492, DateTimeKind.Local).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 342, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 491, DateTimeKind.Local).AddTicks(1259),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 340, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 488, DateTimeKind.Local).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 337, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.AddColumn<string>(
                name: "NumeroONU",
                table: "Produto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemRetencaoFonte",
                table: "Produto",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TipoProdutoId",
                table: "Produto",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 485, DateTimeKind.Local).AddTicks(4181),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 334, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 483, DateTimeKind.Local).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 332, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 482, DateTimeKind.Local).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 331, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 438, DateTimeKind.Local).AddTicks(4786),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 306, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 437, DateTimeKind.Local).AddTicks(1952),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 304, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 434, DateTimeKind.Local).AddTicks(48),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 301, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 432, DateTimeKind.Local).AddTicks(6819),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 300, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 428, DateTimeKind.Local).AddTicks(2465),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 295, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 394, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 258, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 426, DateTimeKind.Local).AddTicks(6933),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 293, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 424, DateTimeKind.Local).AddTicks(9129),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 291, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 421, DateTimeKind.Local).AddTicks(787),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 288, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.AddColumn<int>(
                name: "StockMinimo",
                table: "Compra",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 413, DateTimeKind.Local).AddTicks(1237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 279, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 414, DateTimeKind.Local).AddTicks(8846),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 281, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 411, DateTimeKind.Local).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 277, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 410, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 276, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.CreateTable(
                name: "TipoProduto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 506, DateTimeKind.Local).AddTicks(1266)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProduto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoProduto",
                columns: new[] { "Id", "Descricao", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "Produto", "P", null, true },
                    { 2L, "Serviço", "S", null, true },
                    { 3L, "Outros", "O", null, true },
                    { 4L, "Imposto Especial de Consumo", "IEC", null, true },
                    { 5L, "N/A", "E", null, true },
                    { 6L, "N/A", "T", null, true }
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27d50e45-3610-4299-af27-e32e773de4a9", "AQAAAAEAACcQAAAAEJO9KNM6ZcHTVwG9iZPtDXTlLFjnMFj7mJPbfVHhO4bGXOdN3pJdobStolHBQXKecw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_TipoProdutoId",
                table: "Produto",
                column: "TipoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_TipoProduto_TipoProdutoId",
                table: "Produto",
                column: "TipoProdutoId",
                principalTable: "TipoProduto",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_TipoProduto_TipoProdutoId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "TipoProduto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_TipoProdutoId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NumeroONU",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "TemRetencaoFonte",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "TipoProdutoId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "StockMinimo",
                table: "Compra");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 355, DateTimeKind.Local).AddTicks(4123),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 504, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 352, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 502, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 312, DateTimeKind.Local).AddTicks(1840),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 444, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 350, DateTimeKind.Local).AddTicks(6112),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 500, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 349, DateTimeKind.Local).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 499, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 347, DateTimeKind.Local).AddTicks(7632),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 497, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 346, DateTimeKind.Local).AddTicks(3278),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 496, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 344, DateTimeKind.Local).AddTicks(8815),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 495, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 343, DateTimeKind.Local).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 494, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 342, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 492, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 340, DateTimeKind.Local).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 491, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 337, DateTimeKind.Local).AddTicks(3698),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 488, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 334, DateTimeKind.Local).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 485, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 332, DateTimeKind.Local).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 483, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 331, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 482, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 306, DateTimeKind.Local).AddTicks(1956),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 438, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 304, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 437, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 301, DateTimeKind.Local).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 434, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 300, DateTimeKind.Local).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 432, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 295, DateTimeKind.Local).AddTicks(2713),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 428, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 258, DateTimeKind.Local).AddTicks(7605),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 394, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 293, DateTimeKind.Local).AddTicks(5729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 426, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 291, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 424, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 288, DateTimeKind.Local).AddTicks(248),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 421, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 279, DateTimeKind.Local).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 413, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 281, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 414, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 277, DateTimeKind.Local).AddTicks(7696),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 411, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 276, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 26, 12, 52, 49, 410, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68c43300-63ab-4a36-a8ac-06440dabd5e2", "AQAAAAEAACcQAAAAEHUYHCr5is6hIEybAg8JEc/dq1lj8qvSV3Wwg26Gb3lfZ3bCT+bVC5N5HZmkhtXgkg==" });
        }
    }
}
