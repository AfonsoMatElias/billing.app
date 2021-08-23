using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class NewTablesAdition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 964, DateTimeKind.Local).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 683, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 961, DateTimeKind.Local).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 680, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.AddColumn<long>(
                name: "TipoVendaId",
                table: "Venda",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 996, DateTimeKind.Local).AddTicks(3642),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 718, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 960, DateTimeKind.Local).AddTicks(1517),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 678, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 955, DateTimeKind.Local).AddTicks(9370),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 677, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 953, DateTimeKind.Local).AddTicks(57),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 675, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(9072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 674, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 673, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 948, DateTimeKind.Local).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 672, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 945, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 668, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.AddColumn<decimal>(
                name: "IVA",
                table: "Produto",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 943, DateTimeKind.Local).AddTicks(1967),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 665, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 941, DateTimeKind.Local).AddTicks(2508),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 662, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 936, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 657, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 990, DateTimeKind.Local).AddTicks(3044),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 712, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 987, DateTimeKind.Local).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 710, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.AddColumn<long>(
                name: "TipoFacturaId",
                table: "Factura",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 983, DateTimeKind.Local).AddTicks(6574),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 706, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 925, DateTimeKind.Local).AddTicks(2910),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 645, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 981, DateTimeKind.Local).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 703, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 980, DateTimeKind.Local).AddTicks(552),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 701, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 978, DateTimeKind.Local).AddTicks(7511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 699, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 976, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 696, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 968, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 687, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 969, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 689, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 966, DateTimeKind.Local).AddTicks(9664),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 686, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 965, DateTimeKind.Local).AddTicks(7233),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 685, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.CreateTable(
                name: "MotivoIsencao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classificacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoIsencao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoFactura",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 954, DateTimeKind.Local).AddTicks(4179)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoFactura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVenda",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 958, DateTimeKind.Local).AddTicks(8813)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoMotivoIsencao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    MotivoIsencaoId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 950, DateTimeKind.Local).AddTicks(819)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoMotivoIsencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoMotivoIsencao_MotivoIsencao_MotivoIsencaoId",
                        column: x => x.MotivoIsencaoId,
                        principalTable: "MotivoIsencao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoMotivoIsencao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "a553bdbb-02de-42bf-b25f-de8d24387fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "c0eb3a08-d0fc-47f1-8fb1-a58d7e1b471b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "b5557fca-8156-4fcb-ae5c-a046e46208db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "ae0f5233-96ac-49b9-9885-9ea60f37db03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "bf922380-95f7-4fa4-a579-251e963bd9b2");

            migrationBuilder.InsertData(
                table: "TipoFactura",
                columns: new[] { "Id", "Codigo", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "fpp", "Factura a Pronto Pagamento", null, true },
                    { 2L, "fpf", "Factura Proforma", null, true }
                });

            migrationBuilder.InsertData(
                table: "TipoVenda",
                columns: new[] { "Id", "Codigo", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "vpp", "Venda a Pronto Pagamento", null, true },
                    { 2L, "vc", "Venda a Credito", null, true }
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb4c66dc-e31a-47be-b060-f6d00aaab03a", "AQAAAAEAACcQAAAAEGHbHe/A9vn7FQkOAWvQUsnhpLshpCBGDkybpBYmGS/gANbcph2bQLwFWPVOUyD3qw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_TipoVendaId",
                table: "Venda",
                column: "TipoVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_TipoFacturaId",
                table: "Factura",
                column: "TipoFacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoMotivoIsencao_MotivoIsencaoId",
                table: "ProdutoMotivoIsencao",
                column: "MotivoIsencaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoMotivoIsencao_ProdutoId",
                table: "ProdutoMotivoIsencao",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_TipoFactura_TipoFacturaId",
                table: "Factura",
                column: "TipoFacturaId",
                principalTable: "TipoFactura",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda",
                column: "TipoVendaId",
                principalTable: "TipoVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_TipoFactura_TipoFacturaId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_TipoVenda_TipoVendaId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "ProdutoMotivoIsencao");

            migrationBuilder.DropTable(
                name: "TipoFactura");

            migrationBuilder.DropTable(
                name: "TipoVenda");

            migrationBuilder.DropTable(
                name: "MotivoIsencao");

            migrationBuilder.DropIndex(
                name: "IX_Venda_TipoVendaId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Factura_TipoFacturaId",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "TipoVendaId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "TipoFacturaId",
                table: "Factura");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 683, DateTimeKind.Local).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 964, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 680, DateTimeKind.Local).AddTicks(6431),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 961, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 718, DateTimeKind.Local).AddTicks(7491),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 996, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 678, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 960, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 677, DateTimeKind.Local).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 955, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 675, DateTimeKind.Local).AddTicks(8876),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 953, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 674, DateTimeKind.Local).AddTicks(8206),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 673, DateTimeKind.Local).AddTicks(7629),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 672, DateTimeKind.Local).AddTicks(4440),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 948, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 668, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 945, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 665, DateTimeKind.Local).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 943, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 662, DateTimeKind.Local).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 941, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 657, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 936, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 712, DateTimeKind.Local).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 990, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 710, DateTimeKind.Local).AddTicks(9295),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 987, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 706, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 983, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 645, DateTimeKind.Local).AddTicks(6254),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 925, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 703, DateTimeKind.Local).AddTicks(5391),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 981, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 701, DateTimeKind.Local).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 980, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 699, DateTimeKind.Local).AddTicks(7894),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 978, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 696, DateTimeKind.Local).AddTicks(6916),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 976, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 687, DateTimeKind.Local).AddTicks(9317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 968, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 689, DateTimeKind.Local).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 969, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 686, DateTimeKind.Local).AddTicks(6431),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 966, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 685, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 965, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "6afdc17e-bc80-438d-911a-fc92bd68dc22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "465f490d-d883-43cc-8098-5cec94af11c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "8d91f3b5-5b1e-4032-88ae-dc83a9a2d13e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "2b9cd459-2a61-4921-b87b-0613bf64b256");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "2e9dbd3d-d634-4e41-8fb4-471acae38c02");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90532409-6ff3-4265-a717-1664d97badbe", "AQAAAAEAACcQAAAAEAHT+vw+50xTY9gEmbS8FRhF8mTNxC+++8pj9jWfvCMAIQNq9e6xcqFI7IfOB5G43Q==" });
        }
    }
}
