using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class DataBaseSyncronization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 5, DateTimeKind.Local).AddTicks(9299),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 309, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 3, DateTimeKind.Local).AddTicks(3975),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 307, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 43, DateTimeKind.Local).AddTicks(4789),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 341, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 1, DateTimeKind.Local).AddTicks(4327),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 305, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 999, DateTimeKind.Local).AddTicks(8720),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 303, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 998, DateTimeKind.Local).AddTicks(1572),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 302, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 996, DateTimeKind.Local).AddTicks(7147),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 301, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 995, DateTimeKind.Local).AddTicks(1892),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 300, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 993, DateTimeKind.Local).AddTicks(7302),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 299, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 989, DateTimeKind.Local).AddTicks(1915),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 296, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 984, DateTimeKind.Local).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 293, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 981, DateTimeKind.Local).AddTicks(2762),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 291, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 974, DateTimeKind.Local).AddTicks(1676),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 286, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 37, DateTimeKind.Local).AddTicks(1282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 336, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 35, DateTimeKind.Local).AddTicks(2891),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 334, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 29, DateTimeKind.Local).AddTicks(5949),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 329, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 955, DateTimeKind.Local).AddTicks(4397),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 274, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 27, DateTimeKind.Local).AddTicks(2259),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 327, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 23, DateTimeKind.Local).AddTicks(5005),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 325, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 20, DateTimeKind.Local).AddTicks(7536),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 323, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 10, DateTimeKind.Local).AddTicks(7862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 313, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 12, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 315, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 9, DateTimeKind.Local).AddTicks(3281),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 312, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 7, DateTimeKind.Local).AddTicks(7594),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 311, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.CreateTable(
                name: "TipoContacto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContacto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contaco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    TipoContactoId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 25, DateTimeKind.Local).AddTicks(1142)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacto_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contacto_TipoContacto_TipoContactoId",
                        column: x => x.TipoContactoId,
                        principalTable: "TipoContacto",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "da51ac13-bdc4-4508-8aff-68b97b094509");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "d06f3422-5ae4-4b15-b52a-3ce348781872");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "b4d020c6-8456-44b7-a26d-c5d7b3bac477");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "cc5a39b3-a339-4c14-84e2-6262d6c32e10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "c196f0f2-95e3-46df-85d4-7534f6e9ed0d");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3afedc71-485a-4c9f-b7d5-8cd102e30877", "AQAAAAEAACcQAAAAECmQzdHk28tui0E50YjniHXJMQcABClIF3Wtoc0+2pXuGn9ILXJU0ySK9QblZr8Zow==" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_PessoaId",
                table: "Contacto",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_TipoContactoId",
                table: "Contacto",
                column: "TipoContactoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "TipoContacto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 309, DateTimeKind.Local).AddTicks(3432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 5, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 307, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 3, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 341, DateTimeKind.Local).AddTicks(8139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 43, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 305, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 1, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 303, DateTimeKind.Local).AddTicks(9333),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 999, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 302, DateTimeKind.Local).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 998, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 301, DateTimeKind.Local).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 996, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 300, DateTimeKind.Local).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 995, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 299, DateTimeKind.Local).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 993, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 296, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 989, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 293, DateTimeKind.Local).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 984, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 291, DateTimeKind.Local).AddTicks(2346),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 981, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 286, DateTimeKind.Local).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 974, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 336, DateTimeKind.Local).AddTicks(342),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 37, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 334, DateTimeKind.Local).AddTicks(4307),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 35, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 329, DateTimeKind.Local).AddTicks(5842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 29, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 274, DateTimeKind.Local).AddTicks(2915),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 28, 955, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 327, DateTimeKind.Local).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 27, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 325, DateTimeKind.Local).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 23, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 323, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 20, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 313, DateTimeKind.Local).AddTicks(8338),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 10, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 315, DateTimeKind.Local).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 12, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 312, DateTimeKind.Local).AddTicks(4822),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 9, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 14, 41, 24, 311, DateTimeKind.Local).AddTicks(278),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 27, 14, 31, 29, 7, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1486e21d-6d74-4ade-a772-f90e1fa9ae78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "213e97c8-7345-4c61-8ea2-ab366bd097b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "820d1d3b-2746-4fae-92ce-490132636756");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "d8f3078e-7ea9-4777-b8f3-3788e39cf0d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "b5b03e59-6600-495e-8388-3c368e682c28");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9c60fde-1f23-46a1-9c02-a39288cef33e", "AQAAAAEAACcQAAAAEOe6V3bliuLljLl5CQTRhD5JBY+E0A/f9eol7SIFjUAraUTmltr4bueIlrIPch/mUQ==" });
        }
    }
}
