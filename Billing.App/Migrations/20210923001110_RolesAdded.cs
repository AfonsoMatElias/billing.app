using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 355, DateTimeKind.Local).AddTicks(4123),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 857, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 352, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 856, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 312, DateTimeKind.Local).AddTicks(1840),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 838, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 350, DateTimeKind.Local).AddTicks(6112),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 855, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 349, DateTimeKind.Local).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 854, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 347, DateTimeKind.Local).AddTicks(7632),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 853, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 346, DateTimeKind.Local).AddTicks(3278),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 852, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 344, DateTimeKind.Local).AddTicks(8815),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 852, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 343, DateTimeKind.Local).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 851, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 342, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 850, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 340, DateTimeKind.Local).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 850, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 337, DateTimeKind.Local).AddTicks(3698),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 848, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 334, DateTimeKind.Local).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 846, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 332, DateTimeKind.Local).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 845, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 331, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 845, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 306, DateTimeKind.Local).AddTicks(1956),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 833, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 304, DateTimeKind.Local).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 831, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 301, DateTimeKind.Local).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 828, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 300, DateTimeKind.Local).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 827, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 295, DateTimeKind.Local).AddTicks(2713),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 823, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 258, DateTimeKind.Local).AddTicks(7605),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 790, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 293, DateTimeKind.Local).AddTicks(5729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 821, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 291, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 820, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 288, DateTimeKind.Local).AddTicks(248),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 816, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 279, DateTimeKind.Local).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 808, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 281, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 810, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 277, DateTimeKind.Local).AddTicks(7696),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 807, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 276, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 806, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc90", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9a", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9b", "Gestor", "GESTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9c", "Funcionario", "FUNCIONARIO" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9d", "Vendedor", "VENDEDOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 6L, "ce23b3ea-8d9a-4992-9ec8-b2d002accc9e", "Fornecedor", "FORNECEDOR" },
                    { 7L, "ce23b3ea-8d9a-4992-9ec8-b2d002accc9f", "Cliente", "CLIENTE" }
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68c43300-63ab-4a36-a8ac-06440dabd5e2", "AQAAAAEAACcQAAAAEHUYHCr5is6hIEybAg8JEc/dq1lj8qvSV3Wwg26Gb3lfZ3bCT+bVC5N5HZmkhtXgkg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 857, DateTimeKind.Local).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 355, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 856, DateTimeKind.Local).AddTicks(5089),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 352, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 838, DateTimeKind.Local).AddTicks(1740),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 312, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 855, DateTimeKind.Local).AddTicks(2813),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 350, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 854, DateTimeKind.Local).AddTicks(3842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 349, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 853, DateTimeKind.Local).AddTicks(7054),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 347, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 852, DateTimeKind.Local).AddTicks(9659),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 346, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 852, DateTimeKind.Local).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 344, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 851, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 343, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 850, DateTimeKind.Local).AddTicks(8996),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 342, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 850, DateTimeKind.Local).AddTicks(299),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 340, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 848, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 337, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 846, DateTimeKind.Local).AddTicks(9314),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 334, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 845, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 332, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 845, DateTimeKind.Local).AddTicks(688),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 331, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 833, DateTimeKind.Local).AddTicks(3996),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 306, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 831, DateTimeKind.Local).AddTicks(1366),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 304, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 828, DateTimeKind.Local).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 301, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 827, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 300, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 823, DateTimeKind.Local).AddTicks(2904),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 295, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 790, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 258, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 821, DateTimeKind.Local).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 293, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 820, DateTimeKind.Local).AddTicks(2857),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 291, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 816, DateTimeKind.Local).AddTicks(9414),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 288, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 808, DateTimeKind.Local).AddTicks(7609),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 279, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 810, DateTimeKind.Local).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 281, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 807, DateTimeKind.Local).AddTicks(7613),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 277, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 17, 23, 21, 18, 806, DateTimeKind.Local).AddTicks(5063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 23, 1, 11, 9, 276, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9a", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9b", "Gestor", "GESTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9c", "Funcionario", "FUNCIONARIO" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9d", "Vendedor", "VENDEDOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce23b3ea-8d9a-4992-9ec8-b2d002accc9e", "Entidade", "ENTIDADE" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c6c1673-3654-4922-a375-8e74c453f919", "AQAAAAEAACcQAAAAELnZERbW8ySvQW+WtTjgpEYUDvZAk5vxduiYls11UIpWEXOxjlahRPEA2aSjF2E1vg==" });
        }
    }
}
