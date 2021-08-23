using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class EstabelecimentoPropertyAddedInCompraTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 309, DateTimeKind.Local).AddTicks(5224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 463, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 307, DateTimeKind.Local).AddTicks(8789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 462, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 339, DateTimeKind.Local).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 490, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 306, DateTimeKind.Local).AddTicks(3142),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 461, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 305, DateTimeKind.Local).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 460, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 304, DateTimeKind.Local).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 459, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 303, DateTimeKind.Local).AddTicks(2427),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 458, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 302, DateTimeKind.Local).AddTicks(3549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 457, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 299, DateTimeKind.Local).AddTicks(6391),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 455, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 293, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 450, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 288, DateTimeKind.Local).AddTicks(8875),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 446, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 278, DateTimeKind.Local).AddTicks(9100),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 439, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 334, DateTimeKind.Local).AddTicks(2695),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 484, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 332, DateTimeKind.Local).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 483, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 328, DateTimeKind.Local).AddTicks(6028),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 479, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 326, DateTimeKind.Local).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 477, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 325, DateTimeKind.Local).AddTicks(317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 476, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 322, DateTimeKind.Local).AddTicks(6734),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 474, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.AddColumn<long>(
                name: "EstabelecimentoId",
                table: "Compra",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 313, DateTimeKind.Local).AddTicks(4436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 467, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 315, DateTimeKind.Local).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 468, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 312, DateTimeKind.Local).AddTicks(2896),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 466, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 311, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 465, DateTimeKind.Local).AddTicks(1291));

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
                name: "IX_Compra_EstabelecimentoId",
                table: "Compra",
                column: "EstabelecimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Estabelecimento_EstabelecimentoId",
                table: "Compra",
                column: "EstabelecimentoId",
                principalTable: "Estabelecimento",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Estabelecimento_EstabelecimentoId",
                table: "Compra");

            migrationBuilder.DropIndex(
                name: "IX_Compra_EstabelecimentoId",
                table: "Compra");

            migrationBuilder.DropColumn(
                name: "EstabelecimentoId",
                table: "Compra");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 463, DateTimeKind.Local).AddTicks(9122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 309, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 462, DateTimeKind.Local).AddTicks(4039),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 307, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 490, DateTimeKind.Local).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 339, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 461, DateTimeKind.Local).AddTicks(1820),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 306, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 460, DateTimeKind.Local).AddTicks(1133),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 305, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 459, DateTimeKind.Local).AddTicks(2300),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 304, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 458, DateTimeKind.Local).AddTicks(4445),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 303, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 457, DateTimeKind.Local).AddTicks(7144),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 302, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 455, DateTimeKind.Local).AddTicks(3853),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 299, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 450, DateTimeKind.Local).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 293, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 446, DateTimeKind.Local).AddTicks(1899),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 288, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 439, DateTimeKind.Local).AddTicks(9571),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 278, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 484, DateTimeKind.Local).AddTicks(4386),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 334, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 483, DateTimeKind.Local).AddTicks(1334),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 332, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 479, DateTimeKind.Local).AddTicks(6102),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 328, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 477, DateTimeKind.Local).AddTicks(6220),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 326, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 476, DateTimeKind.Local).AddTicks(3086),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 325, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 474, DateTimeKind.Local).AddTicks(6862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 322, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 467, DateTimeKind.Local).AddTicks(2379),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 313, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 468, DateTimeKind.Local).AddTicks(5307),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 315, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 466, DateTimeKind.Local).AddTicks(2304),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 312, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 9, 6, 39, 465, DateTimeKind.Local).AddTicks(1291),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 3, 17, 9, 45, 32, 311, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "9cbaf4d4-b48d-43f4-a035-52a420c63081");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "9b09a220-e9ba-47de-96d3-98e3d8e3b981");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "7aba98fa-364d-45a4-a95a-577a80409846");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "5cef6767-c484-44fb-b838-71af629b4c2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "feff9679-ea9c-423f-acc4-bdaf4a1722e1");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f362854b-66b1-4c9e-9b3c-e3afc2d4204b", "AQAAAAEAACcQAAAAEIxu42E03IfphZwEDftyS2AXzhqbd49A8OJIFXWLBo6sPodpAMnQXYZdPhC/pwC+oQ==" });
        }
    }
}
