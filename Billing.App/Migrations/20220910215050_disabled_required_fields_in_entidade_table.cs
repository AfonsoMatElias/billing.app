using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class disabled_required_fields_in_entidade_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 431, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 936, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 430, DateTimeKind.Local).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 934, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 406, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 894, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 429, DateTimeKind.Local).AddTicks(1975),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 428, DateTimeKind.Local).AddTicks(5591),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 427, DateTimeKind.Local).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 931, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 427, DateTimeKind.Local).AddTicks(1111),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 930, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 426, DateTimeKind.Local).AddTicks(2958),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 929, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 425, DateTimeKind.Local).AddTicks(5128),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 928, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 424, DateTimeKind.Local).AddTicks(9242),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 927, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 394, DateTimeKind.Local).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 878, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 424, DateTimeKind.Local).AddTicks(277),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 926, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 423, DateTimeKind.Local).AddTicks(3549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 925, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 422, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 924, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 420, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 922, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 418, DateTimeKind.Local).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 920, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 417, DateTimeKind.Local).AddTicks(6189),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 918, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 416, DateTimeKind.Local).AddTicks(3841),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 917, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 415, DateTimeKind.Local).AddTicks(9718),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 916, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "License",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 415, DateTimeKind.Local).AddTicks(2944),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 915, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 402, DateTimeKind.Local).AddTicks(8668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 402, DateTimeKind.Local).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 400, DateTimeKind.Local).AddTicks(3663),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 886, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 399, DateTimeKind.Local).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 885, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 396, DateTimeKind.Local).AddTicks(8765),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 881, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 374, DateTimeKind.Local).AddTicks(6124),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 853, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 395, DateTimeKind.Local).AddTicks(9301),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 880, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 395, DateTimeKind.Local).AddTicks(145),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 879, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 392, DateTimeKind.Local).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 875, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 386, DateTimeKind.Local).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 868, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 387, DateTimeKind.Local).AddTicks(6733),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 870, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 386, DateTimeKind.Local).AddTicks(383),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 867, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 385, DateTimeKind.Local).AddTicks(1624),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 866, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 390, DateTimeKind.Local).AddTicks(6201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 873, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0f8030c-1a4a-468d-9765-8f3e4827cff3", "AQAAAAEAACcQAAAAEETwgOGvQmKsqBF/I0sOpntwlUL6sPoxL36qNnZY7U7Joi7BeT4yyuD/vXTMlaoj1Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 936, DateTimeKind.Local).AddTicks(2372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 431, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 934, DateTimeKind.Local).AddTicks(4844),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 430, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 894, DateTimeKind.Local).AddTicks(5658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 406, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 429, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 932, DateTimeKind.Local).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 428, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 931, DateTimeKind.Local).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 427, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 930, DateTimeKind.Local).AddTicks(1795),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 427, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 929, DateTimeKind.Local).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 426, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 928, DateTimeKind.Local).AddTicks(2606),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 425, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 927, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 424, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 878, DateTimeKind.Local).AddTicks(820),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 394, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 926, DateTimeKind.Local).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 424, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 925, DateTimeKind.Local).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 423, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 924, DateTimeKind.Local).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 422, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 922, DateTimeKind.Local).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 420, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PessoaImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 920, DateTimeKind.Local).AddTicks(2358),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 418, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 918, DateTimeKind.Local).AddTicks(7447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 417, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 917, DateTimeKind.Local).AddTicks(506),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 416, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 916, DateTimeKind.Local).AddTicks(4396),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 415, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "License",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 915, DateTimeKind.Local).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 415, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 402, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 889, DateTimeKind.Local).AddTicks(570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 402, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 886, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 400, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 885, DateTimeKind.Local).AddTicks(4022),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 399, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 881, DateTimeKind.Local).AddTicks(6742),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 396, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 853, DateTimeKind.Local).AddTicks(9752),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 374, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 880, DateTimeKind.Local).AddTicks(3762),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 395, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 879, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 395, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 875, DateTimeKind.Local).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 392, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 868, DateTimeKind.Local).AddTicks(7863),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 386, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 870, DateTimeKind.Local).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 387, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 867, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 386, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 866, DateTimeKind.Local).AddTicks(8155),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 385, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 22, 5, 22, 873, DateTimeKind.Local).AddTicks(4859),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 9, 10, 22, 50, 49, 390, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ee3ac52-aebc-4d1b-8768-c19dad7ce270", "AQAAAAEAACcQAAAAEFWiA5VsuW1n6fGp0tvcoVHcv3QcJOswBE9PRxXSDt+kvYp4ktglxRh7+3QI3CnVSA==" });
        }
    }
}
