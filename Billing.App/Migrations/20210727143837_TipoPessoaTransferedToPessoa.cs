using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class TipoPessoaTransferedToPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 608, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 970, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 606, DateTimeKind.Local).AddTicks(1),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 968, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 642, DateTimeKind.Local).AddTicks(4439),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 5, 3, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 604, DateTimeKind.Local).AddTicks(1977),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 966, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 602, DateTimeKind.Local).AddTicks(6467),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 964, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 601, DateTimeKind.Local).AddTicks(2689),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 963, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 600, DateTimeKind.Local).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 962, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 599, DateTimeKind.Local).AddTicks(4418),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 598, DateTimeKind.Local).AddTicks(5619),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 595, DateTimeKind.Local).AddTicks(8019),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 958, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 592, DateTimeKind.Local).AddTicks(7702),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 955, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.AddColumn<long>(
                name: "TipoPessoaId",
                table: "Pessoa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 589, DateTimeKind.Local).AddTicks(5122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 953, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 585, DateTimeKind.Local).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 948, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 636, DateTimeKind.Local).AddTicks(9917),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 997, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 635, DateTimeKind.Local).AddTicks(4798),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 996, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 631, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 992, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 574, DateTimeKind.Local).AddTicks(372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 937, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 629, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 990, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 627, DateTimeKind.Local).AddTicks(3925),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 988, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 625, DateTimeKind.Local).AddTicks(8380),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 986, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 622, DateTimeKind.Local).AddTicks(2060),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 984, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 613, DateTimeKind.Local).AddTicks(3432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 975, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 615, DateTimeKind.Local).AddTicks(2886),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 977, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 611, DateTimeKind.Local).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 973, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 610, DateTimeKind.Local).AddTicks(1534),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 972, DateTimeKind.Local).AddTicks(3656));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 970, DateTimeKind.Local).AddTicks(8295),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 608, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 968, DateTimeKind.Local).AddTicks(3219),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 606, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 5, 3, DateTimeKind.Local).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 642, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 966, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 604, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 964, DateTimeKind.Local).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 602, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 963, DateTimeKind.Local).AddTicks(6789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 601, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 962, DateTimeKind.Local).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 600, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(8861),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 599, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 598, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 958, DateTimeKind.Local).AddTicks(3066),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 595, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 955, DateTimeKind.Local).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 592, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 953, DateTimeKind.Local).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 589, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 948, DateTimeKind.Local).AddTicks(8735),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 585, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 997, DateTimeKind.Local).AddTicks(9222),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 636, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 996, DateTimeKind.Local).AddTicks(4950),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 635, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 992, DateTimeKind.Local).AddTicks(3220),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 631, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 937, DateTimeKind.Local).AddTicks(6248),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 574, DateTimeKind.Local).AddTicks(372));

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
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 990, DateTimeKind.Local).AddTicks(2726),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 629, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 988, DateTimeKind.Local).AddTicks(1893),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 627, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 986, DateTimeKind.Local).AddTicks(7505),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 625, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 984, DateTimeKind.Local).AddTicks(3511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 622, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 975, DateTimeKind.Local).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 613, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 977, DateTimeKind.Local).AddTicks(1138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 615, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 973, DateTimeKind.Local).AddTicks(6576),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 611, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 972, DateTimeKind.Local).AddTicks(3656),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 38, 36, 610, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "abf9495d-3a63-4402-b632-5c7b00a96055");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "d3f740fa-a219-44a4-806a-2b7615e8fe9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "a7d56fe8-6877-4311-97ca-4e6089c75d70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "583da686-401b-48d7-a9e6-c910dedfdeb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "0ce63904-f185-44d4-a6f0-4034a79d9aac");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e31d997b-b9e3-43c4-b882-5fa9d35b6e84", "AQAAAAEAACcQAAAAEJbYJP3bNjevAQwrxc4AaHdsq+gwtJ9+gUAvRCsog9nXZ+XyK+rgXafC/cwDQDGU3w==" });

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
    }
}
