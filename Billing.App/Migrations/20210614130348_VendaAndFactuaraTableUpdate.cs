using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class VendaAndFactuaraTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 522, DateTimeKind.Local).AddTicks(2818),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 365, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.AddColumn<decimal>(
                name: "Desconto",
                table: "VendaItem",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "VendaItem",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 520, DateTimeKind.Local).AddTicks(1470),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 363, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.AddColumn<bool>(
                name: "IsPausada",
                table: "Venda",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 552, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 403, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 518, DateTimeKind.Local).AddTicks(3863),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 362, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 516, DateTimeKind.Local).AddTicks(9998),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 360, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(9878),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 359, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(838),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 358, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 514, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 356, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 511, DateTimeKind.Local).AddTicks(4891),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 352, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 505, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 339, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 500, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 332, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 491, DateTimeKind.Local).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 317, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 546, DateTimeKind.Local).AddTicks(9718),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 396, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 545, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 394, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 541, DateTimeKind.Local).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 390, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 539, DateTimeKind.Local).AddTicks(6224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 388, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 538, DateTimeKind.Local).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 386, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 535, DateTimeKind.Local).AddTicks(7331),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 383, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 526, DateTimeKind.Local).AddTicks(3232),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 371, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 527, DateTimeKind.Local).AddTicks(8997),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 374, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 525, DateTimeKind.Local).AddTicks(642),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 370, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 523, DateTimeKind.Local).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 367, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "2fd838c7-ea9f-4712-9355-7faabd810589");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "010e7c45-6191-4b62-9c46-e3f2ad4e8d74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "cacb1921-771f-44f0-af32-2f318a458872");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "aa63dd13-1a48-457d-b27f-8ae6acc39ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "4bf809e8-9261-4b58-853a-7d94fe9709e6");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ea4fdc9-d169-44eb-8565-a3f5f7090ac7", "AQAAAAEAACcQAAAAEICI+55BFItN4uOVqGYWX23dREGK3iK21ARKBQZ64JMMJb0g0OQnYhWkzmgVV66LyQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desconto",
                table: "VendaItem");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "VendaItem");

            migrationBuilder.DropColumn(
                name: "IsPausada",
                table: "Venda");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 365, DateTimeKind.Local).AddTicks(2317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 522, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 363, DateTimeKind.Local).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 520, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 403, DateTimeKind.Local).AddTicks(3148),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 552, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 362, DateTimeKind.Local).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 518, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 360, DateTimeKind.Local).AddTicks(4955),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 516, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 359, DateTimeKind.Local).AddTicks(3655),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 358, DateTimeKind.Local).AddTicks(300),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 356, DateTimeKind.Local).AddTicks(7677),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 514, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 352, DateTimeKind.Local).AddTicks(4808),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 511, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 339, DateTimeKind.Local).AddTicks(3309),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 505, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 332, DateTimeKind.Local).AddTicks(2612),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 500, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 317, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 491, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 396, DateTimeKind.Local).AddTicks(518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 546, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 394, DateTimeKind.Local).AddTicks(5262),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 545, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 390, DateTimeKind.Local).AddTicks(5602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 541, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 388, DateTimeKind.Local).AddTicks(5898),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 539, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 386, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 538, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 383, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 535, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 371, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 526, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 374, DateTimeKind.Local).AddTicks(2279),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 527, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 370, DateTimeKind.Local).AddTicks(1694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 525, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 367, DateTimeKind.Local).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 523, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "7fafe6fd-e485-4003-9940-b187ec52e5a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "7737b92d-71f1-4f6b-bc04-e61538d77149");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "28044e56-aef7-42f7-9b31-077b02dfb4ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "9f78b077-2d19-4975-b2ba-27a5214628e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "f5685370-f79a-48c0-9af1-ebc442ae798b");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46fdc7b9-9b21-44dd-9587-0d4f16167d18", "AQAAAAEAACcQAAAAEC9ABgzWas3JmiBwOvT+zHvUSkB0VlYtose++CLvOt3h1UIfFwWISg6GzOLhCEUO9g==" });
        }
    }
}
