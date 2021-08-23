using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class DatabaseSomeNewSyncronization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 970, DateTimeKind.Local).AddTicks(8295),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 45, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 968, DateTimeKind.Local).AddTicks(3219),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 42, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 5, 3, DateTimeKind.Local).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 76, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 966, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 40, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 964, DateTimeKind.Local).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 38, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 963, DateTimeKind.Local).AddTicks(6789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 37, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 962, DateTimeKind.Local).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 36, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(8861),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 35, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 34, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 958, DateTimeKind.Local).AddTicks(3066),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 30, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.AlterColumn<string>(
                name: "UltimoNome",
                table: "Pessoa",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimeiroNome",
                table: "Pessoa",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 955, DateTimeKind.Local).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 27, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 953, DateTimeKind.Local).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 25, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 948, DateTimeKind.Local).AddTicks(8735),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 21, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 997, DateTimeKind.Local).AddTicks(9222),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 70, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 996, DateTimeKind.Local).AddTicks(4950),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 69, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 992, DateTimeKind.Local).AddTicks(3220),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 65, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 937, DateTimeKind.Local).AddTicks(6248),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 9, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 990, DateTimeKind.Local).AddTicks(2726),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 63, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 988, DateTimeKind.Local).AddTicks(1893),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 61, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 986, DateTimeKind.Local).AddTicks(7505),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 59, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 984, DateTimeKind.Local).AddTicks(3511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 57, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 975, DateTimeKind.Local).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 49, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 977, DateTimeKind.Local).AddTicks(1138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 51, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 973, DateTimeKind.Local).AddTicks(6576),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 48, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 972, DateTimeKind.Local).AddTicks(3656),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 46, DateTimeKind.Local).AddTicks(8968));

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
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa",
                column: "TipoEntidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 45, DateTimeKind.Local).AddTicks(3892),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 970, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 42, DateTimeKind.Local).AddTicks(9381),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 968, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 76, DateTimeKind.Local).AddTicks(2938),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 5, 3, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 40, DateTimeKind.Local).AddTicks(5080),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 966, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 38, DateTimeKind.Local).AddTicks(9872),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 964, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 37, DateTimeKind.Local).AddTicks(3936),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 963, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 36, DateTimeKind.Local).AddTicks(998),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 962, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 35, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 34, DateTimeKind.Local).AddTicks(584),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 961, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 30, DateTimeKind.Local).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 958, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.AlterColumn<string>(
                name: "UltimoNome",
                table: "Pessoa",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimeiroNome",
                table: "Pessoa",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 27, DateTimeKind.Local).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 955, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 25, DateTimeKind.Local).AddTicks(8115),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 953, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 21, DateTimeKind.Local).AddTicks(5294),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 948, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 70, DateTimeKind.Local).AddTicks(6900),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 997, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 69, DateTimeKind.Local).AddTicks(2255),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 996, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 65, DateTimeKind.Local).AddTicks(254),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 992, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 9, DateTimeKind.Local).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 937, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 63, DateTimeKind.Local).AddTicks(1900),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 990, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 61, DateTimeKind.Local).AddTicks(4937),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 988, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 59, DateTimeKind.Local).AddTicks(8902),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 986, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 57, DateTimeKind.Local).AddTicks(5943),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 984, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 49, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 975, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 51, DateTimeKind.Local).AddTicks(3532),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 977, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 48, DateTimeKind.Local).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 973, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 54, 53, 46, DateTimeKind.Local).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 15, 3, 4, 972, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "6fcf4eca-5a1e-4c96-a451-7374d2df2a7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "334d9940-5309-4ccf-b112-7ce945e36720");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "704a8c49-0c2d-4e74-b4a4-6554518b0916");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "49675c71-f58f-434a-ac28-8b75c0ffb390");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "1d76dcec-b644-4c32-b0b9-9cacb8bfa1b7");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd662c82-8790-4dd3-82e1-4242f9626834", "AQAAAAEAACcQAAAAEJa4atm6pgpiZG6q+d+OhPtKgESP9AxpJCkIa/dlVy17uxbD3sy0BuUAmsVu4xXKhA==" });
        }
    }
}
