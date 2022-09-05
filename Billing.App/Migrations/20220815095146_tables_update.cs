using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class tables_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ProdutoImagem");

            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 666, DateTimeKind.Local).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 249, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 664, DateTimeKind.Local).AddTicks(7810),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 248, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 631, DateTimeKind.Local).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 227, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 663, DateTimeKind.Local).AddTicks(2515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 247, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 662, DateTimeKind.Local).AddTicks(3746),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 246, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 661, DateTimeKind.Local).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 660, DateTimeKind.Local).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 659, DateTimeKind.Local).AddTicks(5019),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 244, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 658, DateTimeKind.Local).AddTicks(5510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 243, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 657, DateTimeKind.Local).AddTicks(7862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 614, DateTimeKind.Local).AddTicks(7563),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 214, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 656, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 655, DateTimeKind.Local).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 241, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 654, DateTimeKind.Local).AddTicks(5322),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 240, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "ProdutoImagem",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "ProdutoImagem",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProdutoImagem",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueName",
                table: "ProdutoImagem",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 652, DateTimeKind.Local).AddTicks(1578),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 239, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 648, DateTimeKind.Local).AddTicks(8555),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 237, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 647, DateTimeKind.Local).AddTicks(924),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 236, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 646, DateTimeKind.Local).AddTicks(4666),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 235, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 626, DateTimeKind.Local).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 223, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 625, DateTimeKind.Local).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 222, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 622, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 220, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 621, DateTimeKind.Local).AddTicks(8583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 219, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 618, DateTimeKind.Local).AddTicks(3598),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 217, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 590, DateTimeKind.Local).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 195, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 617, DateTimeKind.Local).AddTicks(692),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 216, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 615, DateTimeKind.Local).AddTicks(7943),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 215, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 612, DateTimeKind.Local).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 213, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 605, DateTimeKind.Local).AddTicks(5645),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 606, DateTimeKind.Local).AddTicks(8063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 604, DateTimeKind.Local).AddTicks(6303),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 207, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 603, DateTimeKind.Local).AddTicks(5892),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 206, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 610, DateTimeKind.Local).AddTicks(2045),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 211, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.CreateTable(
                name: "PessoaImagem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 650, DateTimeKind.Local).AddTicks(3282)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UniqueName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaImagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaImagem_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0131266b-7403-46ba-8f9a-563c228f0356", "AQAAAAEAACcQAAAAEFKSX7Q1FCfXEbCcMatAMeMBsg57Wru5ho9ykTZiMtiEnj85xIxn84d0ExN4XZNJLQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaImagem_PessoaId",
                table: "PessoaImagem",
                column: "PessoaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaImagem");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "ProdutoImagem");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "ProdutoImagem");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProdutoImagem");

            migrationBuilder.DropColumn(
                name: "UniqueName",
                table: "ProdutoImagem");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 249, DateTimeKind.Local).AddTicks(6461),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 666, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 248, DateTimeKind.Local).AddTicks(4646),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 664, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 227, DateTimeKind.Local).AddTicks(2912),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 631, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 247, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 663, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 246, DateTimeKind.Local).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 662, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 661, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 660, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 244, DateTimeKind.Local).AddTicks(5833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 659, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 243, DateTimeKind.Local).AddTicks(3581),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 658, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(8565),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 657, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 214, DateTimeKind.Local).AddTicks(9073),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 614, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(522),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 656, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 241, DateTimeKind.Local).AddTicks(5200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 655, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 240, DateTimeKind.Local).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 654, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ProdutoImagem",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 239, DateTimeKind.Local).AddTicks(2714),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 652, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 237, DateTimeKind.Local).AddTicks(7174),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 648, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "Pessoa",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 236, DateTimeKind.Local).AddTicks(1774),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 647, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 235, DateTimeKind.Local).AddTicks(6962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 646, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 223, DateTimeKind.Local).AddTicks(5046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 626, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 222, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 625, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 220, DateTimeKind.Local).AddTicks(5246),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 622, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 219, DateTimeKind.Local).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 621, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 217, DateTimeKind.Local).AddTicks(2744),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 618, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 195, DateTimeKind.Local).AddTicks(2315),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 590, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 216, DateTimeKind.Local).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 617, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 215, DateTimeKind.Local).AddTicks(5777),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 615, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 213, DateTimeKind.Local).AddTicks(265),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 612, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(6),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 605, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(8613),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 606, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 207, DateTimeKind.Local).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 604, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 206, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 603, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 211, DateTimeKind.Local).AddTicks(851),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 8, 15, 10, 51, 45, 610, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ced68d-1ba5-4490-8e89-0f151345c468", "AQAAAAEAACcQAAAAEPRvx0Zbxhk9HW+LK8COdY7N26jzv3F3ioH2sSVYFAHJjbEj55OAV03rE1tHjHcD7Q==" });
        }
    }
}
