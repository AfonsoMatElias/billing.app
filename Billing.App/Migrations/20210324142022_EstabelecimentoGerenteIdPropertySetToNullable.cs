using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class EstabelecimentoGerenteIdPropertySetToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estabelecimento_GerenteId",
                table: "Estabelecimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 119, DateTimeKind.Local).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 309, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 117, DateTimeKind.Local).AddTicks(5031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 307, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 151, DateTimeKind.Local).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 339, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 116, DateTimeKind.Local).AddTicks(922),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 306, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 114, DateTimeKind.Local).AddTicks(9127),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 305, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 113, DateTimeKind.Local).AddTicks(8783),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 304, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(9701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 303, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 302, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 109, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 299, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 102, DateTimeKind.Local).AddTicks(9217),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 293, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 98, DateTimeKind.Local).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 288, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 86, DateTimeKind.Local).AddTicks(4594),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 278, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 146, DateTimeKind.Local).AddTicks(3485),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 334, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 144, DateTimeKind.Local).AddTicks(6748),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 332, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.AlterColumn<long>(
                name: "GerenteId",
                table: "Estabelecimento",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 139, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 328, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 137, DateTimeKind.Local).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 326, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 135, DateTimeKind.Local).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 325, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 133, DateTimeKind.Local).AddTicks(3669),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 322, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 123, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 313, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 125, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 315, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 122, DateTimeKind.Local).AddTicks(907),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 312, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 120, DateTimeKind.Local).AddTicks(7147),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 311, DateTimeKind.Local).AddTicks(408));

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

            migrationBuilder.CreateIndex(
                name: "IX_Estabelecimento_GerenteId",
                table: "Estabelecimento",
                column: "GerenteId",
                unique: true,
                filter: "[GerenteId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estabelecimento_GerenteId",
                table: "Estabelecimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 309, DateTimeKind.Local).AddTicks(5224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 119, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 307, DateTimeKind.Local).AddTicks(8789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 117, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 339, DateTimeKind.Local).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 151, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 306, DateTimeKind.Local).AddTicks(3142),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 116, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 305, DateTimeKind.Local).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 114, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 304, DateTimeKind.Local).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 113, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 303, DateTimeKind.Local).AddTicks(2427),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 302, DateTimeKind.Local).AddTicks(3549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 112, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 299, DateTimeKind.Local).AddTicks(6391),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 109, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 293, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 102, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 288, DateTimeKind.Local).AddTicks(8875),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 98, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 278, DateTimeKind.Local).AddTicks(9100),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 86, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 334, DateTimeKind.Local).AddTicks(2695),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 146, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 332, DateTimeKind.Local).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 144, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.AlterColumn<long>(
                name: "GerenteId",
                table: "Estabelecimento",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 328, DateTimeKind.Local).AddTicks(6028),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 139, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 326, DateTimeKind.Local).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 137, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 325, DateTimeKind.Local).AddTicks(317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 135, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 322, DateTimeKind.Local).AddTicks(6734),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 133, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 313, DateTimeKind.Local).AddTicks(4436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 123, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 315, DateTimeKind.Local).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 125, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 312, DateTimeKind.Local).AddTicks(2896),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 122, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 311, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 24, 15, 20, 21, 120, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "6d88f42a-d12a-425e-a307-9e7ee03eb7fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "01f78083-d4b3-4a44-90ff-ea1d32a22a76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "769de960-aa5b-4bd7-b942-c303b6ac8d3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "a0505c80-0ec9-433a-b01f-f6a210eca773");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "87309dc8-9239-4329-8656-c202ce17d163");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72136fcf-47de-47e3-bdd5-0f51e8186091", "AQAAAAEAACcQAAAAEMiEgXKSBi7oCBtH+yruV6maqDoieaZKGtZE6aRIhwagmBgTcWFMqhZcPxgJxacWwA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Estabelecimento_GerenteId",
                table: "Estabelecimento",
                column: "GerenteId",
                unique: true);
        }
    }
}
