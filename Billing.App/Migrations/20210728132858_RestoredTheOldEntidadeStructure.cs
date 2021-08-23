using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class RestoredTheOldEntidadeStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_TipoPessoa_TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "IsFornecedor",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "TipoPessoaId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 710, DateTimeKind.Local).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 680, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 707, DateTimeKind.Local).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 677, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 748, DateTimeKind.Local).AddTicks(4045),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 713, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 705, DateTimeKind.Local).AddTicks(1113),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 675, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 703, DateTimeKind.Local).AddTicks(1436),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 674, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 701, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 673, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 700, DateTimeKind.Local).AddTicks(4144),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 671, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 699, DateTimeKind.Local).AddTicks(3708),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 670, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 698, DateTimeKind.Local).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 669, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 694, DateTimeKind.Local).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 667, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 691, DateTimeKind.Local).AddTicks(7168),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 663, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 689, DateTimeKind.Local).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 660, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 684, DateTimeKind.Local).AddTicks(5874),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 656, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 741, DateTimeKind.Local).AddTicks(6426),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 707, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 739, DateTimeKind.Local).AddTicks(1843),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 705, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 733, DateTimeKind.Local).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 701, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 670, DateTimeKind.Local).AddTicks(9469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 644, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AddColumn<long>(
                name: "TipoPessoaId",
                table: "Entidade",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 731, DateTimeKind.Local).AddTicks(6616),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 699, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 729, DateTimeKind.Local).AddTicks(6446),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 697, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 727, DateTimeKind.Local).AddTicks(8729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 695, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 725, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 693, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 715, DateTimeKind.Local).AddTicks(5655),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 684, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 717, DateTimeKind.Local).AddTicks(6652),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 686, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 713, DateTimeKind.Local).AddTicks(4841),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 683, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 711, DateTimeKind.Local).AddTicks(9502),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 681, DateTimeKind.Local).AddTicks(8160));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 680, DateTimeKind.Local).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 710, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 677, DateTimeKind.Local).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 707, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 713, DateTimeKind.Local).AddTicks(122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 748, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 675, DateTimeKind.Local).AddTicks(9602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 705, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 674, DateTimeKind.Local).AddTicks(5739),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 703, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 673, DateTimeKind.Local).AddTicks(1043),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 701, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 671, DateTimeKind.Local).AddTicks(9691),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 700, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 670, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 699, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 669, DateTimeKind.Local).AddTicks(9051),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 698, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 667, DateTimeKind.Local).AddTicks(1558),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 694, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 663, DateTimeKind.Local).AddTicks(6205),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 691, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.AddColumn<bool>(
                name: "IsFornecedor",
                table: "Pessoa",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "TipoPessoaId",
                table: "Pessoa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 660, DateTimeKind.Local).AddTicks(8603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 689, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 656, DateTimeKind.Local).AddTicks(3484),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 684, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 707, DateTimeKind.Local).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 741, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 705, DateTimeKind.Local).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 739, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 701, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 733, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 644, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 670, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 699, DateTimeKind.Local).AddTicks(1674),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 731, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 697, DateTimeKind.Local).AddTicks(2867),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 729, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 695, DateTimeKind.Local).AddTicks(7339),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 727, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 693, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 725, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 684, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 715, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 686, DateTimeKind.Local).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 717, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 683, DateTimeKind.Local).AddTicks(2270),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 713, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 10, 42, 10, 681, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 28, 14, 28, 57, 711, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1b520506-2965-413d-899d-24ea21c89ee7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "0173ac2a-6a27-4d5d-8ee5-c234aec837cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "3d2984a1-3a96-4988-9394-cfae24153f69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "dd9d721c-192e-4292-abee-46b6597823ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "53bae1dc-56cc-4f09-80c9-bac62a272587");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34eaebe2-7eda-4ddd-a942-e8a343d7cdc1", "AQAAAAEAACcQAAAAEFi84EMW1UzQbANUVEZbMg3qV8S6ourRFfCHFnch28XsV/TN8r4qTNir+yHmxwuGPQ==" });

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
    }
}
