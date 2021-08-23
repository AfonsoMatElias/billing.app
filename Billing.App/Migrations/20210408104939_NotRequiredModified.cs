using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class NotRequiredModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 365, DateTimeKind.Local).AddTicks(2317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 119, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 363, DateTimeKind.Local).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 117, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 403, DateTimeKind.Local).AddTicks(3148),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 151, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 362, DateTimeKind.Local).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 116, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 360, DateTimeKind.Local).AddTicks(4955),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 114, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 359, DateTimeKind.Local).AddTicks(3655),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 113, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 358, DateTimeKind.Local).AddTicks(300),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 356, DateTimeKind.Local).AddTicks(7677),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 352, DateTimeKind.Local).AddTicks(4808),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 109, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 339, DateTimeKind.Local).AddTicks(3309),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 102, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 332, DateTimeKind.Local).AddTicks(2612),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 98, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 317, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 86, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 396, DateTimeKind.Local).AddTicks(518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 146, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 394, DateTimeKind.Local).AddTicks(5262),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 144, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 390, DateTimeKind.Local).AddTicks(5602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 139, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 388, DateTimeKind.Local).AddTicks(5898),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 137, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 386, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 135, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.AlterColumn<long>(
                name: "FornecedorId",
                table: "Compra",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 383, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 133, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 371, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 123, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 374, DateTimeKind.Local).AddTicks(2279),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 125, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 370, DateTimeKind.Local).AddTicks(1694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 122, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 367, DateTimeKind.Local).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 120, DateTimeKind.Local).AddTicks(7147));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 119, DateTimeKind.Local).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 365, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 117, DateTimeKind.Local).AddTicks(5031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 363, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 151, DateTimeKind.Local).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 403, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 116, DateTimeKind.Local).AddTicks(922),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 362, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 114, DateTimeKind.Local).AddTicks(9127),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 360, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 113, DateTimeKind.Local).AddTicks(8783),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 359, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(9701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 358, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 356, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 109, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 352, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 102, DateTimeKind.Local).AddTicks(9217),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 339, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 98, DateTimeKind.Local).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 332, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 86, DateTimeKind.Local).AddTicks(4594),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 317, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 146, DateTimeKind.Local).AddTicks(3485),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 396, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 144, DateTimeKind.Local).AddTicks(6748),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 394, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 139, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 390, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 137, DateTimeKind.Local).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 388, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 135, DateTimeKind.Local).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 386, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<long>(
                name: "FornecedorId",
                table: "Compra",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 133, DateTimeKind.Local).AddTicks(3669),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 383, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 123, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 371, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 125, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 374, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 122, DateTimeKind.Local).AddTicks(907),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 370, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 120, DateTimeKind.Local).AddTicks(7147),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 4, 8, 11, 49, 38, 367, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "4e7bc621-37e0-40cb-afc0-d8d05ed5fcb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "3056ea9b-a225-4a39-91d4-356725322c68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "eced080d-de49-4cd7-b739-2ce7c9805021");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "a9a4de98-4591-4357-a630-5782b7cb1125");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "96303875-0bac-42c1-9df0-2f0bbaac0464");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c71a947-0dce-465e-9ab7-520a9408655b", "AQAAAAEAACcQAAAAECDI/7f7Swczs2VTH5knYy//r/7Re4xULgOZoVU7wy4Y/kNVX0zMU6dUax6IzQcmLA==" });
        }
    }
}
