using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class CompraAudityFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 683, DateTimeKind.Local).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 896, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 680, DateTimeKind.Local).AddTicks(6431),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 893, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 718, DateTimeKind.Local).AddTicks(7491),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 930, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 678, DateTimeKind.Local).AddTicks(7634),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 891, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 677, DateTimeKind.Local).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 890, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 675, DateTimeKind.Local).AddTicks(8876),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 888, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 674, DateTimeKind.Local).AddTicks(8206),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 887, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 673, DateTimeKind.Local).AddTicks(7629),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 886, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 672, DateTimeKind.Local).AddTicks(4440),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 885, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 668, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 882, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 665, DateTimeKind.Local).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 879, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 662, DateTimeKind.Local).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 877, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 657, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 872, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 712, DateTimeKind.Local).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 924, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 710, DateTimeKind.Local).AddTicks(9295),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 923, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 706, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 918, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 645, DateTimeKind.Local).AddTicks(6254),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 859, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 703, DateTimeKind.Local).AddTicks(5391),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 916, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 701, DateTimeKind.Local).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 914, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 699, DateTimeKind.Local).AddTicks(7894),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 912, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 696, DateTimeKind.Local).AddTicks(6916),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 909, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEntrada",
                table: "Compra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 687, DateTimeKind.Local).AddTicks(9317),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 901, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 689, DateTimeKind.Local).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 902, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 686, DateTimeKind.Local).AddTicks(6431),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 899, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 685, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 898, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "6afdc17e-bc80-438d-911a-fc92bd68dc22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "465f490d-d883-43cc-8098-5cec94af11c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "8d91f3b5-5b1e-4032-88ae-dc83a9a2d13e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "2b9cd459-2a61-4921-b87b-0613bf64b256");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "2e9dbd3d-d634-4e41-8fb4-471acae38c02");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90532409-6ff3-4265-a717-1664d97badbe", "AQAAAAEAACcQAAAAEAHT+vw+50xTY9gEmbS8FRhF8mTNxC+++8pj9jWfvCMAIQNq9e6xcqFI7IfOB5G43Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeEntrada",
                table: "Compra");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 896, DateTimeKind.Local).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 683, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 893, DateTimeKind.Local).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 680, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 930, DateTimeKind.Local).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 718, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 891, DateTimeKind.Local).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 678, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 890, DateTimeKind.Local).AddTicks(5180),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 677, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 888, DateTimeKind.Local).AddTicks(9679),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 675, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 887, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 674, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 886, DateTimeKind.Local).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 673, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 885, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 672, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 882, DateTimeKind.Local).AddTicks(4612),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 668, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 879, DateTimeKind.Local).AddTicks(5138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 665, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 877, DateTimeKind.Local).AddTicks(792),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 662, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 872, DateTimeKind.Local).AddTicks(4603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 657, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 924, DateTimeKind.Local).AddTicks(8591),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 712, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 923, DateTimeKind.Local).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 710, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 918, DateTimeKind.Local).AddTicks(4097),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 706, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 859, DateTimeKind.Local).AddTicks(8989),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 645, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 916, DateTimeKind.Local).AddTicks(2524),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 703, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 914, DateTimeKind.Local).AddTicks(2182),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 701, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 912, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 699, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 909, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 696, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 901, DateTimeKind.Local).AddTicks(403),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 687, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 902, DateTimeKind.Local).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 689, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 899, DateTimeKind.Local).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 686, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 898, DateTimeKind.Local).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 29, 14, 58, 8, 685, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1cebb76d-f5ae-4977-b431-1a48402baa51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "07e89536-ed0d-491c-a5c2-a78e7d61845f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "e70eaabf-f1d2-4cc9-90da-3a4d048df926");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "148cf80c-9410-4c2e-abe3-0c9d32d93517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "2b98ecae-fa90-4041-8b85-be868de35aca");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb9e90d-e63e-4fcc-a7ce-de9439d8aeec", "AQAAAAEAACcQAAAAEMJoSnbuN3VSc8Ui1G3kDoyBRC3ZrEMHG0iDCYoQKMNvPkpe6JtQRqxpQv7+OWLYeg==" });
        }
    }
}
