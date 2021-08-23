using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class DroppedNIFColumnInEntidadeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_TipoPessoa_TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "NIF",
                table: "Entidade");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 309, DateTimeKind.Local).AddTicks(3432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 518, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 307, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 516, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 341, DateTimeKind.Local).AddTicks(8139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 551, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 305, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 514, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 303, DateTimeKind.Local).AddTicks(9333),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 513, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 302, DateTimeKind.Local).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 512, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 301, DateTimeKind.Local).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 510, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 300, DateTimeKind.Local).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 299, DateTimeKind.Local).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 296, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 506, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 293, DateTimeKind.Local).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 502, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 291, DateTimeKind.Local).AddTicks(2346),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 499, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 286, DateTimeKind.Local).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 495, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 336, DateTimeKind.Local).AddTicks(342),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 545, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 334, DateTimeKind.Local).AddTicks(4307),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 543, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 329, DateTimeKind.Local).AddTicks(5842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 539, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 274, DateTimeKind.Local).AddTicks(2915),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 483, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AddColumn<long>(
                name: "TipoPessoaId",
                table: "Entidade",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 327, DateTimeKind.Local).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 536, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AddColumn<bool>(
                name: "IsPrincipal",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 325, DateTimeKind.Local).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 534, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 323, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 532, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 313, DateTimeKind.Local).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 523, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 315, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 525, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 312, DateTimeKind.Local).AddTicks(4822),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 522, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 311, DateTimeKind.Local).AddTicks(278),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 520, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1486e21d-6d74-4ade-a772-f90e1fa9ae78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "213e97c8-7345-4c61-8ea2-ab366bd097b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "820d1d3b-2746-4fae-92ce-490132636756");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "d8f3078e-7ea9-4777-b8f3-3788e39cf0d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "b5b03e59-6600-495e-8388-3c368e682c28");

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Codigo",
                value: "tec");

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Codigo",
                value: "tef");

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Codigo",
                value: "tps");

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Codigo",
                value: "tpc");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9c60fde-1f23-46a1-9c02-a39288cef33e", "AQAAAAEAACcQAAAAEOe6V3bliuLljLl5CQTRhD5JBY+E0A/f9eol7SIFjUAraUTmltr4bueIlrIPch/mUQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Entidade_TipoPessoaId",
                table: "Entidade",
                column: "TipoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_TipoPessoa_TipoPessoaId",
                table: "Entidade",
                column: "TipoPessoaId",
                principalTable: "TipoPessoa",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_TipoPessoa_TipoPessoaId",
                table: "Entidade");

            migrationBuilder.DropIndex(
                name: "IX_Entidade_TipoPessoaId",
                table: "Entidade");

            migrationBuilder.DropColumn(
                name: "TipoPessoaId",
                table: "Entidade");

            migrationBuilder.DropColumn(
                name: "IsPrincipal",
                table: "Endereco");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 518, DateTimeKind.Local).AddTicks(8057),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 309, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 516, DateTimeKind.Local).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 307, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 551, DateTimeKind.Local).AddTicks(1264),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 341, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 514, DateTimeKind.Local).AddTicks(7169),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 305, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 513, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 303, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 512, DateTimeKind.Local).AddTicks(849),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 302, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 510, DateTimeKind.Local).AddTicks(9181),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 301, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(9929),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 300, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 299, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 506, DateTimeKind.Local).AddTicks(607),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 296, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 502, DateTimeKind.Local).AddTicks(4939),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 293, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.AddColumn<long>(
                name: "TipoPessoaId",
                table: "Pessoa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 499, DateTimeKind.Local).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 291, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 495, DateTimeKind.Local).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 286, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 545, DateTimeKind.Local).AddTicks(6285),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 336, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 543, DateTimeKind.Local).AddTicks(8961),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 334, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 539, DateTimeKind.Local).AddTicks(944),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 329, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 483, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 274, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.AddColumn<string>(
                name: "NIF",
                table: "Entidade",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 536, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 327, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 534, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 325, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 532, DateTimeKind.Local).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 323, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 523, DateTimeKind.Local).AddTicks(5986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 313, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 525, DateTimeKind.Local).AddTicks(2078),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 315, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 522, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 312, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 520, DateTimeKind.Local).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 311, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "3f9b30ef-73b0-4c91-abc9-a9f7ce80fbc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "71eec7e8-b0ac-405a-aa7e-aeb1b8bf9088");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "c4d16385-4eea-47e1-913f-8dd5dc1df97a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "61b3c381-9798-4620-a825-65b811145ae9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "fcfe9dbd-ef64-44a1-af5a-8c0bacf3b570");

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Codigo",
                value: "01");

            migrationBuilder.UpdateData(
                table: "TipoEntidade",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Codigo",
                value: "02");

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Codigo",
                value: "01");

            migrationBuilder.UpdateData(
                table: "TipoPessoa",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Codigo",
                value: "02");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "370dc451-221b-48a8-937c-bdb0af5442b9", "AQAAAAEAACcQAAAAEK95Q2TkZVzWanKoWybZnmEAR/Rzvk+5YvzNmxMbGoPEpYvWOaYVxt0S2KaQ0OluUA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TipoPessoaId",
                table: "Pessoa",
                column: "TipoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_TipoPessoa_TipoPessoaId",
                table: "Pessoa",
                column: "TipoPessoaId",
                principalTable: "TipoPessoa",
                principalColumn: "Id");
        }
    }
}
