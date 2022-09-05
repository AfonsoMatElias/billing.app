using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class increased_column_size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 920, DateTimeKind.Local).AddTicks(5888),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 666, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 919, DateTimeKind.Local).AddTicks(2723),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 664, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 897, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 631, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 918, DateTimeKind.Local).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 663, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 917, DateTimeKind.Local).AddTicks(5890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 662, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(9082),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 661, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(2554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 660, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 915, DateTimeKind.Local).AddTicks(6104),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 659, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(9443),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 658, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 657, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 886, DateTimeKind.Local).AddTicks(3795),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 614, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(6189),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 656, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 655, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.AlterColumn<string>(
                name: "UniqueName",
                table: "ProdutoImagem",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProdutoImagem",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 912, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 654, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 910, DateTimeKind.Local).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 652, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 909, DateTimeKind.Local).AddTicks(2406),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 650, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 908, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 648, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(9791),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 647, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(5779),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 646, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 894, DateTimeKind.Local).AddTicks(3441),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 626, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 893, DateTimeKind.Local).AddTicks(7924),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 625, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(9569),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 622, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(3237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 621, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(9119),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 618, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 869, DateTimeKind.Local).AddTicks(5828),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 590, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 617, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 887, DateTimeKind.Local).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 615, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 884, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 612, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 605, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 880, DateTimeKind.Local).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 606, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 604, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 878, DateTimeKind.Local).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 603, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 883, DateTimeKind.Local).AddTicks(1556),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 610, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b48c057-5923-4e03-8e31-9a372493e92a", "AQAAAAEAACcQAAAAEMiJ16OAFH4GgXwZ3sFa70/4Sb2azPTm16vQqeenRNUorl9cBfnrwY6tCPNVwmI6bQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 666, DateTimeKind.Local).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 920, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 664, DateTimeKind.Local).AddTicks(7810),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 919, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 631, DateTimeKind.Local).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 897, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 663, DateTimeKind.Local).AddTicks(2515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 918, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 662, DateTimeKind.Local).AddTicks(3746),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 917, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 661, DateTimeKind.Local).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 660, DateTimeKind.Local).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 659, DateTimeKind.Local).AddTicks(5019),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 915, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 658, DateTimeKind.Local).AddTicks(5510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 657, DateTimeKind.Local).AddTicks(7862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 614, DateTimeKind.Local).AddTicks(7563),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 886, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 656, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 655, DateTimeKind.Local).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.AlterColumn<string>(
                name: "UniqueName",
                table: "ProdutoImagem",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProdutoImagem",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 654, DateTimeKind.Local).AddTicks(5322),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 912, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 652, DateTimeKind.Local).AddTicks(1578),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 910, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 650, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 909, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 648, DateTimeKind.Local).AddTicks(8555),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 908, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 647, DateTimeKind.Local).AddTicks(924),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 646, DateTimeKind.Local).AddTicks(4666),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 626, DateTimeKind.Local).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 894, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 625, DateTimeKind.Local).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 893, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 622, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 621, DateTimeKind.Local).AddTicks(8583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 618, DateTimeKind.Local).AddTicks(3598),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 590, DateTimeKind.Local).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 869, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 617, DateTimeKind.Local).AddTicks(692),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 615, DateTimeKind.Local).AddTicks(7943),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 887, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 612, DateTimeKind.Local).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 884, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 605, DateTimeKind.Local).AddTicks(5645),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 606, DateTimeKind.Local).AddTicks(8063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 880, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 604, DateTimeKind.Local).AddTicks(6303),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 603, DateTimeKind.Local).AddTicks(5892),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 878, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 610, DateTimeKind.Local).AddTicks(2045),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 883, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0131266b-7403-46ba-8f9a-563c228f0356", "AQAAAAEAACcQAAAAEFKSX7Q1FCfXEbCcMatAMeMBsg57Wru5ho9ykTZiMtiEnj85xIxn84d0ExN4XZNJLQ==" });
        }
    }
}
