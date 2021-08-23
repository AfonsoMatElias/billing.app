using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 896, DateTimeKind.Local).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 710, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 893, DateTimeKind.Local).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 707, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 930, DateTimeKind.Local).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 748, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 891, DateTimeKind.Local).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 705, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 890, DateTimeKind.Local).AddTicks(5180),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 703, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 888, DateTimeKind.Local).AddTicks(9679),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 701, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 887, DateTimeKind.Local).AddTicks(8423),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 700, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 886, DateTimeKind.Local).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 699, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 885, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 698, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 882, DateTimeKind.Local).AddTicks(4612),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 694, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 879, DateTimeKind.Local).AddTicks(5138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 691, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 877, DateTimeKind.Local).AddTicks(792),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 689, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 872, DateTimeKind.Local).AddTicks(4603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 684, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 924, DateTimeKind.Local).AddTicks(8591),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 741, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 923, DateTimeKind.Local).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 739, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 918, DateTimeKind.Local).AddTicks(4097),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 733, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.AlterColumn<long>(
                name: "TipoPessoaId",
                table: "Entidade",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 859, DateTimeKind.Local).AddTicks(8989),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 670, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 916, DateTimeKind.Local).AddTicks(2524),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 731, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 914, DateTimeKind.Local).AddTicks(2182),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 729, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 912, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 727, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 909, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 725, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 901, DateTimeKind.Local).AddTicks(403),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 715, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 902, DateTimeKind.Local).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 717, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 899, DateTimeKind.Local).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 713, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 898, DateTimeKind.Local).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 711, DateTimeKind.Local).AddTicks(9502));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 710, DateTimeKind.Local).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 896, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 707, DateTimeKind.Local).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 893, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 748, DateTimeKind.Local).AddTicks(4045),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 930, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 705, DateTimeKind.Local).AddTicks(1113),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 891, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 703, DateTimeKind.Local).AddTicks(1436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 890, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 701, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 888, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 700, DateTimeKind.Local).AddTicks(4144),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 887, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 699, DateTimeKind.Local).AddTicks(3708),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 886, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 698, DateTimeKind.Local).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 885, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 694, DateTimeKind.Local).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 882, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 691, DateTimeKind.Local).AddTicks(7168),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 879, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 689, DateTimeKind.Local).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 877, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 684, DateTimeKind.Local).AddTicks(5874),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 872, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 741, DateTimeKind.Local).AddTicks(6426),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 924, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 739, DateTimeKind.Local).AddTicks(1843),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 923, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 733, DateTimeKind.Local).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 918, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.AlterColumn<long>(
                name: "TipoPessoaId",
                table: "Entidade",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 670, DateTimeKind.Local).AddTicks(9469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 859, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 731, DateTimeKind.Local).AddTicks(6616),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 916, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 729, DateTimeKind.Local).AddTicks(6446),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 914, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 727, DateTimeKind.Local).AddTicks(8729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 912, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 725, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 909, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 715, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 901, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 717, DateTimeKind.Local).AddTicks(6652),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 902, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 713, DateTimeKind.Local).AddTicks(4841),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 899, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 711, DateTimeKind.Local).AddTicks(9502),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 44, 22, 898, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "ffd29f26-6308-4e63-8cbc-51a7a9b986e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "03d8af2d-a988-4462-8a07-6ebcfa8e0c06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "e4d61f04-1502-40f9-89d8-e7067003e25a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "0e4a5485-4856-474e-a626-ebe51060683b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "4fca3030-2d3e-48e7-b316-a913782604f0");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ffdee46-891d-41a9-9273-702ff45cc3a1", "AQAAAAEAACcQAAAAEK5XhvNVS9IpxnNzG7+SorgpEZ7Mi4EgrwrRaesi9Tn1MV34P3Uxb8JXJPBh2iRffg==" });
        }
    }
}
