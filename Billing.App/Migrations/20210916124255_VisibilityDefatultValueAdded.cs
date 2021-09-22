using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class VisibilityDefatultValueAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "VendaItem",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 200, DateTimeKind.Local).AddTicks(73),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 237, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Venda",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 198, DateTimeKind.Local).AddTicks(5437),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 236, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 218, DateTimeKind.Local).AddTicks(8644),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 253, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Titulo",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 197, DateTimeKind.Local).AddTicks(3497),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 234, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoVenda",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 196, DateTimeKind.Local).AddTicks(7772),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 234, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoPessoa",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 196, DateTimeKind.Local).AddTicks(473),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 233, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoFactura",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 195, DateTimeKind.Local).AddTicks(2648),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 233, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoEntidade",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 194, DateTimeKind.Local).AddTicks(6224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 232, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoContacto",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 193, DateTimeKind.Local).AddTicks(9404),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 231, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "SubCategoria",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 193, DateTimeKind.Local).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 231, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoMotivoIsencao",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 192, DateTimeKind.Local).AddTicks(6837),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 230, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoImagem",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 191, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 229, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Produto",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 190, DateTimeKind.Local).AddTicks(4268),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 228, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pessoa",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 188, DateTimeKind.Local).AddTicks(9547),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 227, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pais",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 226, DateTimeKind.Local).AddTicks(6706),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 260, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "MotivoIsencao",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 188, DateTimeKind.Local).AddTicks(411),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 226, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Genero",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 185, DateTimeKind.Local).AddTicks(5383),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 224, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Funcionario",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 212, DateTimeKind.Local).AddTicks(5247),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 249, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "FormaPagamento",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 211, DateTimeKind.Local).AddTicks(9156),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 249, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Factura",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 211, DateTimeKind.Local).AddTicks(3576),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 248, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Estabelecimento",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 209, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 246, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Entidade",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 176, DateTimeKind.Local).AddTicks(4104),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 216, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Endereco",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 208, DateTimeKind.Local).AddTicks(6290),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 245, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Contacto",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 207, DateTimeKind.Local).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 244, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Compra",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 206, DateTimeKind.Local).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 243, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessageAttachment",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 201, DateTimeKind.Local).AddTicks(9191),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 239, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessage",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 202, DateTimeKind.Local).AddTicks(8312),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 240, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Chat",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 201, DateTimeKind.Local).AddTicks(3576),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 238, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Categoria",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 200, DateTimeKind.Local).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 238, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea1244ad-b281-4c71-aa83-c3b8bd5c6c81", "AQAAAAEAACcQAAAAEOKFZPLY6ve1nQlXNSKTJLR/OUSZkthA2bKSLJMmXJ4U5cPrjfewJ3cVOV56n2VKOw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "VendaItem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 237, DateTimeKind.Local).AddTicks(4337),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 200, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Venda",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 236, DateTimeKind.Local).AddTicks(1304),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 198, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 253, DateTimeKind.Local).AddTicks(3895),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 218, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Titulo",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 234, DateTimeKind.Local).AddTicks(9597),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 197, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoVenda",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 234, DateTimeKind.Local).AddTicks(3009),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 196, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoPessoa",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 233, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 196, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoFactura",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 233, DateTimeKind.Local).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 195, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoEntidade",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 232, DateTimeKind.Local).AddTicks(3350),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 194, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "TipoContacto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 231, DateTimeKind.Local).AddTicks(6782),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 193, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "SubCategoria",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 231, DateTimeKind.Local).AddTicks(2256),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 193, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoMotivoIsencao",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 230, DateTimeKind.Local).AddTicks(5781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 192, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ProdutoImagem",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 229, DateTimeKind.Local).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 191, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 228, DateTimeKind.Local).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 190, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 227, DateTimeKind.Local).AddTicks(1737),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 188, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Pais",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 260, DateTimeKind.Local).AddTicks(6520),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 226, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "MotivoIsencao",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 226, DateTimeKind.Local).AddTicks(3451),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 188, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Genero",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 224, DateTimeKind.Local).AddTicks(1907),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 185, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Funcionario",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 249, DateTimeKind.Local).AddTicks(7033),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 212, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "FormaPagamento",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 249, DateTimeKind.Local).AddTicks(1182),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 211, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Factura",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 248, DateTimeKind.Local).AddTicks(5639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 211, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Estabelecimento",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 246, DateTimeKind.Local).AddTicks(4289),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 209, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Entidade",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 216, DateTimeKind.Local).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 176, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 245, DateTimeKind.Local).AddTicks(6047),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 208, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Contacto",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 244, DateTimeKind.Local).AddTicks(7575),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 207, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Compra",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 243, DateTimeKind.Local).AddTicks(6237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 206, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessageAttachment",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 239, DateTimeKind.Local).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 201, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "ChatMessage",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 240, DateTimeKind.Local).AddTicks(1320),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 202, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Chat",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 238, DateTimeKind.Local).AddTicks(7789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 201, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.AlterColumn<bool>(
                name: "Visibility",
                table: "Categoria",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 16, 13, 33, 26, 238, DateTimeKind.Local).AddTicks(1220),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 9, 16, 13, 42, 55, 200, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01acf281-b717-4a79-af7e-6fee7dd5a4da", "AQAAAAEAACcQAAAAEFBrsF94buHOymApmukjlS0zxHE9uhWpOeXLVkWoYbwwQMlrdZ3q5/uXkpwcih0+9Q==" });
        }
    }
}
