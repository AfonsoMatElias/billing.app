using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class database_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 936, DateTimeKind.Local).AddTicks(2372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 920, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 934, DateTimeKind.Local).AddTicks(4844),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 919, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 894, DateTimeKind.Local).AddTicks(5658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 897, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 918, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 917, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 931, DateTimeKind.Local).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 930, DateTimeKind.Local).AddTicks(1795),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 929, DateTimeKind.Local).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 915, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 928, DateTimeKind.Local).AddTicks(2606),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 927, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 878, DateTimeKind.Local).AddTicks(820),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 886, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 926, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 925, DateTimeKind.Local).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 924, DateTimeKind.Local).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 912, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 922, DateTimeKind.Local).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 910, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 920, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 909, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 918, DateTimeKind.Local).AddTicks(7447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 908, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 917, DateTimeKind.Local).AddTicks(506),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 916, DateTimeKind.Local).AddTicks(4396),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "License",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 915, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "License",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visibility",
                table: "License",
                type: "bit",
                nullable: true,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 894, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 893, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 886, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 885, DateTimeKind.Local).AddTicks(4022),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 881, DateTimeKind.Local).AddTicks(6742),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 853, DateTimeKind.Local).AddTicks(9752),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 869, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 880, DateTimeKind.Local).AddTicks(3762),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 879, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 887, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 875, DateTimeKind.Local).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 884, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 868, DateTimeKind.Local).AddTicks(7863),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 870, DateTimeKind.Local).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 880, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 867, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 866, DateTimeKind.Local).AddTicks(8155),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 878, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 873, DateTimeKind.Local).AddTicks(4859),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 883, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ee3ac52-aebc-4d1b-8768-c19dad7ce270", "AQAAAAEAACcQAAAAEFWiA5VsuW1n6fGp0tvcoVHcv3QcJOswBE9PRxXSDt+kvYp4ktglxRh7+3QI3CnVSA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "License");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "License");

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "License");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ChatMessage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 920, DateTimeKind.Local).AddTicks(5888),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 936, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 919, DateTimeKind.Local).AddTicks(2723),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 934, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 897, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 894, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 918, DateTimeKind.Local).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 917, DateTimeKind.Local).AddTicks(5890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(9082),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 931, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 916, DateTimeKind.Local).AddTicks(2554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 930, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 915, DateTimeKind.Local).AddTicks(6104),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 929, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(9443),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 928, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 914, DateTimeKind.Local).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 927, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 886, DateTimeKind.Local).AddTicks(3795),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 878, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(6189),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 926, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 913, DateTimeKind.Local).AddTicks(282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 925, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 912, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 924, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 910, DateTimeKind.Local).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 922, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 909, DateTimeKind.Local).AddTicks(2406),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 920, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 908, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 918, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(9791),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 917, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 906, DateTimeKind.Local).AddTicks(5779),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 916, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 894, DateTimeKind.Local).AddTicks(3441),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 893, DateTimeKind.Local).AddTicks(7924),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(9569),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 886, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 891, DateTimeKind.Local).AddTicks(3237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 885, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(9119),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 881, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 869, DateTimeKind.Local).AddTicks(5828),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 853, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 888, DateTimeKind.Local).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 880, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 887, DateTimeKind.Local).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 879, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 884, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 875, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 868, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 880, DateTimeKind.Local).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 870, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 879, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 867, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 878, DateTimeKind.Local).AddTicks(5786),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 866, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 11, 30, 48, 883, DateTimeKind.Local).AddTicks(1556),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 873, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b48c057-5923-4e03-8e31-9a372493e92a", "AQAAAAEAACcQAAAAEMiJ16OAFH4GgXwZ3sFa70/4Sb2azPTm16vQqeenRNUorl9cBfnrwY6tCPNVwmI6bQ==" });
        }
    }
}
