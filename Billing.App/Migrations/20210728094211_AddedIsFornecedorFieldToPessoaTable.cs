using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class AddedIsFornecedorFieldToPessoaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 680, DateTimeKind.Local).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 579, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 677, DateTimeKind.Local).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 576, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 713, DateTimeKind.Local).AddTicks(122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 610, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 675, DateTimeKind.Local).AddTicks(9602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 574, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 674, DateTimeKind.Local).AddTicks(5739),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 572, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 673, DateTimeKind.Local).AddTicks(1043),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 571, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 671, DateTimeKind.Local).AddTicks(9691),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 570, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 670, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 569, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 669, DateTimeKind.Local).AddTicks(9051),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 568, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 667, DateTimeKind.Local).AddTicks(1558),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 565, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 663, DateTimeKind.Local).AddTicks(6205),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 562, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.AddColumn<bool>(
                name: "IsFornecedor",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 660, DateTimeKind.Local).AddTicks(8603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 560, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 656, DateTimeKind.Local).AddTicks(3484),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 555, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 707, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 605, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 705, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 603, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 701, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 599, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 644, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 543, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 699, DateTimeKind.Local).AddTicks(1674),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 597, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 697, DateTimeKind.Local).AddTicks(2867),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 596, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 695, DateTimeKind.Local).AddTicks(7339),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 594, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 693, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 592, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 684, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 584, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 686, DateTimeKind.Local).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 586, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 683, DateTimeKind.Local).AddTicks(2270),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 583, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 681, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 581, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1b520506-2965-413d-899d-24ea21c89ee7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "0173ac2a-6a27-4d5d-8ee5-c234aec837cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "3d2984a1-3a96-4988-9394-cfae24153f69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "dd9d721c-192e-4292-abee-46b6597823ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "53bae1dc-56cc-4f09-80c9-bac62a272587");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34eaebe2-7eda-4ddd-a942-e8a343d7cdc1", "AQAAAAEAACcQAAAAEFi84EMW1UzQbANUVEZbMg3qV8S6ourRFfCHFnch28XsV/TN8r4qTNir+yHmxwuGPQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFornecedor",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 579, DateTimeKind.Local).AddTicks(417),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 680, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 576, DateTimeKind.Local).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 677, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 610, DateTimeKind.Local).AddTicks(8435),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 713, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 574, DateTimeKind.Local).AddTicks(2109),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 675, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 572, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 674, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 571, DateTimeKind.Local).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 673, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 570, DateTimeKind.Local).AddTicks(4188),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 671, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 569, DateTimeKind.Local).AddTicks(5206),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 670, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 568, DateTimeKind.Local).AddTicks(5916),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 669, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 565, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 667, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 562, DateTimeKind.Local).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 663, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 560, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 660, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 555, DateTimeKind.Local).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 656, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 605, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 707, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 603, DateTimeKind.Local).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 705, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 599, DateTimeKind.Local).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 701, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 543, DateTimeKind.Local).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 644, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 597, DateTimeKind.Local).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 699, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 596, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 697, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 594, DateTimeKind.Local).AddTicks(8554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 695, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 592, DateTimeKind.Local).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 693, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 584, DateTimeKind.Local).AddTicks(5787),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 684, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 586, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 686, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 583, DateTimeKind.Local).AddTicks(958),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 683, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 40, 43, 581, DateTimeKind.Local).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 681, DateTimeKind.Local).AddTicks(8160));

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
    }
}
