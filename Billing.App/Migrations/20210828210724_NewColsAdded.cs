using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class NewColsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 729, DateTimeKind.Local).AddTicks(8362),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 964, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 727, DateTimeKind.Local).AddTicks(6196),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 961, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 765, DateTimeKind.Local).AddTicks(3456),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 996, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 725, DateTimeKind.Local).AddTicks(5265),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 960, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 724, DateTimeKind.Local).AddTicks(94),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 958, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 720, DateTimeKind.Local).AddTicks(3581),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 955, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 718, DateTimeKind.Local).AddTicks(8005),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 954, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 717, DateTimeKind.Local).AddTicks(385),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 953, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 715, DateTimeKind.Local).AddTicks(7654),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 714, DateTimeKind.Local).AddTicks(9576),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 713, DateTimeKind.Local).AddTicks(8188),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 950, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 712, DateTimeKind.Local).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 948, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 709, DateTimeKind.Local).AddTicks(7221),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 945, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 707, DateTimeKind.Local).AddTicks(1100),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 943, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 705, DateTimeKind.Local).AddTicks(2165),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 941, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 701, DateTimeKind.Local).AddTicks(222),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 936, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 758, DateTimeKind.Local).AddTicks(5355),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 990, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 756, DateTimeKind.Local).AddTicks(244),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 987, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 750, DateTimeKind.Local).AddTicks(3991),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 983, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 688, DateTimeKind.Local).AddTicks(4069),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 925, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 747, DateTimeKind.Local).AddTicks(9230),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 981, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 745, DateTimeKind.Local).AddTicks(6821),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 980, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 743, DateTimeKind.Local).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 978, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 741, DateTimeKind.Local).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 976, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 733, DateTimeKind.Local).AddTicks(7644),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 968, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 735, DateTimeKind.Local).AddTicks(2520),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 969, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 732, DateTimeKind.Local).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 966, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 731, DateTimeKind.Local).AddTicks(3276),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 965, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "7fba62eb-867d-45c9-ae4c-0626e2b39ca8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "8757423d-d974-4480-8d34-49147180d815");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "c0feeb85-5b79-4810-9eb4-a9ba7ad48627");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "298f47a3-80c3-4d87-99f7-5240df721892");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "30a47e24-b3d3-4363-b7b9-e7a3400d2ba6");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f25315f-571b-4833-997d-1614908aee0f", "AQAAAAEAACcQAAAAEExerowLXBhdRiURapSZC5jMYL4pLUc8yT3E/6kqfzy25xKFTxN9MYPkaMJ7E8ZX/A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 964, DateTimeKind.Local).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 729, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 961, DateTimeKind.Local).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 727, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 996, DateTimeKind.Local).AddTicks(3642),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 765, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 960, DateTimeKind.Local).AddTicks(1517),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 725, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 958, DateTimeKind.Local).AddTicks(8813),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 724, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 955, DateTimeKind.Local).AddTicks(9370),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 720, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 954, DateTimeKind.Local).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 718, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 953, DateTimeKind.Local).AddTicks(57),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 717, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(9072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 715, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 951, DateTimeKind.Local).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 714, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 950, DateTimeKind.Local).AddTicks(819),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 713, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 948, DateTimeKind.Local).AddTicks(6864),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 712, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 945, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 709, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 943, DateTimeKind.Local).AddTicks(1967),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 707, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 941, DateTimeKind.Local).AddTicks(2508),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 705, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 936, DateTimeKind.Local).AddTicks(9041),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 701, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 990, DateTimeKind.Local).AddTicks(3044),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 758, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 987, DateTimeKind.Local).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 756, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 983, DateTimeKind.Local).AddTicks(6574),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 750, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 925, DateTimeKind.Local).AddTicks(2910),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 688, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 981, DateTimeKind.Local).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 747, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 980, DateTimeKind.Local).AddTicks(552),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 745, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 978, DateTimeKind.Local).AddTicks(7511),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 743, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 976, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 741, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 968, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 733, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 969, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 735, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 966, DateTimeKind.Local).AddTicks(9664),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 732, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 22, 16, 23, 37, 965, DateTimeKind.Local).AddTicks(7233),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 8, 28, 22, 7, 23, 731, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "a553bdbb-02de-42bf-b25f-de8d24387fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "c0eb3a08-d0fc-47f1-8fb1-a58d7e1b471b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "b5557fca-8156-4fcb-ae5c-a046e46208db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "ae0f5233-96ac-49b9-9885-9ea60f37db03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "bf922380-95f7-4fa4-a579-251e963bd9b2");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb4c66dc-e31a-47be-b060-f6d00aaab03a", "AQAAAAEAACcQAAAAEGHbHe/A9vn7FQkOAWvQUsnhpLshpCBGDkybpBYmGS/gANbcph2bQLwFWPVOUyD3qw==" });
        }
    }
}
