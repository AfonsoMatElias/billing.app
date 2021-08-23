using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class FieldUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 579, DateTimeKind.Local).AddTicks(417),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 608, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 576, DateTimeKind.Local).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 606, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 610, DateTimeKind.Local).AddTicks(8435),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 642, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 574, DateTimeKind.Local).AddTicks(2109),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 604, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 572, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 602, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 571, DateTimeKind.Local).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 601, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 570, DateTimeKind.Local).AddTicks(4188),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 600, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 569, DateTimeKind.Local).AddTicks(5206),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 599, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 568, DateTimeKind.Local).AddTicks(5916),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 598, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 565, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 595, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.AlterColumn<long>(
                name: "TipoPessoaId",
                table: "Pessoa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 562, DateTimeKind.Local).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 592, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 560, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 589, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 555, DateTimeKind.Local).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 585, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 605, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 636, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 603, DateTimeKind.Local).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 635, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 599, DateTimeKind.Local).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 631, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 543, DateTimeKind.Local).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 574, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 597, DateTimeKind.Local).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 629, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 596, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 627, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 594, DateTimeKind.Local).AddTicks(8554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 625, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 592, DateTimeKind.Local).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 622, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 584, DateTimeKind.Local).AddTicks(5787),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 613, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 586, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 615, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 583, DateTimeKind.Local).AddTicks(958),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 611, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 581, DateTimeKind.Local).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 610, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "908067a3-0aed-4e52-b5eb-27247542b0e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "5745be1f-7b03-4ac5-b9d4-f05f00aa2855");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "e21eac4f-8e5a-415b-a393-421267373957");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "7ad960b1-7a86-401d-b315-d593e05fb475");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "470390e9-3835-490b-b5ec-6c52d8964672");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2372c4e6-5616-4f3a-88e3-412a84d15366", "AQAAAAEAACcQAAAAEOuy9J9f28x8pVWMSTovQog41UbHiWmnf5zdOOEfMgCwKo0h1swreBRzIXaRP50G8g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 608, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 579, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 606, DateTimeKind.Local).AddTicks(1),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 576, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 642, DateTimeKind.Local).AddTicks(4439),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 610, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 604, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 574, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 602, DateTimeKind.Local).AddTicks(6467),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 572, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 601, DateTimeKind.Local).AddTicks(2689),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 571, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 600, DateTimeKind.Local).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 570, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 599, DateTimeKind.Local).AddTicks(4418),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 569, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 598, DateTimeKind.Local).AddTicks(5619),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 568, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 595, DateTimeKind.Local).AddTicks(8019),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 565, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<long>(
                name: "TipoPessoaId",
                table: "Pessoa",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 592, DateTimeKind.Local).AddTicks(7702),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 562, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 589, DateTimeKind.Local).AddTicks(5122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 560, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 585, DateTimeKind.Local).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 555, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 636, DateTimeKind.Local).AddTicks(9917),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 605, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 635, DateTimeKind.Local).AddTicks(4798),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 603, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 631, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 599, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 574, DateTimeKind.Local).AddTicks(372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 543, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 629, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 597, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 627, DateTimeKind.Local).AddTicks(3925),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 596, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 625, DateTimeKind.Local).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 594, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 622, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 592, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 613, DateTimeKind.Local).AddTicks(3432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 584, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 615, DateTimeKind.Local).AddTicks(2886),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 586, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 611, DateTimeKind.Local).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 583, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 610, DateTimeKind.Local).AddTicks(1534),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 581, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "220e0255-c036-4900-bb88-81cf1fe43892");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "1e483df0-3676-4ac7-9fc4-2076ce2dacef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "a3584bfe-121b-4cd7-a7e9-b399b18e13c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "59ad6364-afcd-4509-9c9d-c2fadeae4f8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "f164688a-1be4-4b8a-8a35-d984ca3088be");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec31736e-d26a-45d0-a510-b9188bba8f30", "AQAAAAEAACcQAAAAEHMZK/jGKXC3NjD1mAJVGaahF/FPUqWRph56YKKG2IcYyAqapXTQWTSMEHLAcP1LDQ==" });
        }
    }
}
