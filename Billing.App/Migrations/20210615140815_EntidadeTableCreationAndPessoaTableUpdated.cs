using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class EntidadeTableCreationAndPessoaTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Pessoa_FornecedorId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Pessoa_ClienteId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 518, DateTimeKind.Local).AddTicks(8057),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 522, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 516, DateTimeKind.Local).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 519, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 551, DateTimeKind.Local).AddTicks(1264),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 552, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 514, DateTimeKind.Local).AddTicks(7169),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 517, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 513, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 516, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 510, DateTimeKind.Local).AddTicks(9181),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 515, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(9929),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 514, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 513, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 506, DateTimeKind.Local).AddTicks(607),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 510, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 502, DateTimeKind.Local).AddTicks(4939),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 504, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.AddColumn<long>(
                name: "TipoEntidadeId",
                table: "Pessoa",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 499, DateTimeKind.Local).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 499, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 495, DateTimeKind.Local).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 489, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 545, DateTimeKind.Local).AddTicks(6285),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 547, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 543, DateTimeKind.Local).AddTicks(8961),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 545, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 539, DateTimeKind.Local).AddTicks(944),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 541, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 536, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 539, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 534, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 537, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 532, DateTimeKind.Local).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 535, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 523, DateTimeKind.Local).AddTicks(5986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 526, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 525, DateTimeKind.Local).AddTicks(2078),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 527, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 522, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 525, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 520, DateTimeKind.Local).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 523, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.CreateTable(
                name: "TipoEntidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 512, DateTimeKind.Local).AddTicks(849)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEntidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEntidadeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 483, DateTimeKind.Local).AddTicks(3339)),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Visibility = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entidade_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entidade_TipoEntidade_TipoEntidadeId",
                        column: x => x.TipoEntidadeId,
                        principalTable: "TipoEntidade",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "3f9b30ef-73b0-4c91-abc9-a9f7ce80fbc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "71eec7e8-b0ac-405a-aa7e-aeb1b8bf9088");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "c4d16385-4eea-47e1-913f-8dd5dc1df97a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61b3c381-9798-4620-a825-65b811145ae9", "Vendedor", "VENDEDOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fcfe9dbd-ef64-44a1-af5a-8c0bacf3b570", "Entidade", "ENTIDADE" });

            migrationBuilder.InsertData(
                table: "TipoEntidade",
                columns: new[] { "Id", "Codigo", "Nome", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1L, "01", "Cliente", null, true },
                    { 2L, "02", "Fornecedor", null, true }
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "370dc451-221b-48a8-937c-bdb0af5442b9", "AQAAAAEAACcQAAAAEK95Q2TkZVzWanKoWybZnmEAR/Rzvk+5YvzNmxMbGoPEpYvWOaYVxt0S2KaQ0OluUA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa",
                column: "TipoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entidade_PessoaId",
                table: "Entidade",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entidade_TipoEntidadeId",
                table: "Entidade",
                column: "TipoEntidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Entidade_FornecedorId",
                table: "Compra",
                column: "FornecedorId",
                principalTable: "Entidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_TipoEntidade_TipoEntidadeId",
                table: "Pessoa",
                column: "TipoEntidadeId",
                principalTable: "TipoEntidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Entidade_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Entidade",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Entidade_FornecedorId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_TipoEntidade_TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Entidade_ClienteId",
                table: "Venda");

            migrationBuilder.DropTable(
                name: "Entidade");

            migrationBuilder.DropTable(
                name: "TipoEntidade");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "TipoEntidadeId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 522, DateTimeKind.Local).AddTicks(260),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 518, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 519, DateTimeKind.Local).AddTicks(5859),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 516, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 552, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 551, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 517, DateTimeKind.Local).AddTicks(8917),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 514, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 516, DateTimeKind.Local).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 513, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 515, DateTimeKind.Local).AddTicks(7101),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 510, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 514, DateTimeKind.Local).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 513, DateTimeKind.Local).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 509, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 510, DateTimeKind.Local).AddTicks(9683),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 506, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 504, DateTimeKind.Local).AddTicks(5062),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 502, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.AddColumn<long>(
                name: "UsuarioId",
                table: "Pessoa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 499, DateTimeKind.Local).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 499, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 489, DateTimeKind.Local).AddTicks(6185),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 495, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 547, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 545, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 545, DateTimeKind.Local).AddTicks(9458),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 543, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 541, DateTimeKind.Local).AddTicks(2781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 539, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 539, DateTimeKind.Local).AddTicks(2613),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 536, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 537, DateTimeKind.Local).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 534, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 535, DateTimeKind.Local).AddTicks(3133),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 532, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 526, DateTimeKind.Local).AddTicks(2826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 523, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 527, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 525, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 525, DateTimeKind.Local).AddTicks(549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 522, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 523, DateTimeKind.Local).AddTicks(6769),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 15, 8, 14, 520, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "027c9151-b3ee-4452-9606-ed395a79c1d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "721797cc-30b1-4ce3-96f0-a90371913361");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "b8fc33c1-3d7e-43c3-b0f5-e144f1ddfdc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "841ee490-a971-420e-bee2-18e493360918", "Fornecedor", "FORNECEDOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff9af3ab-10f1-4f13-a1e7-3a1f6ae72942", "Vendedor", "VENDEDOR" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a163f29b-6358-4539-8b97-918c3d48053f", "AQAAAAEAACcQAAAAEGVQ/uXtq8SmzVNTVjVhXqcYA18dfsKgj86t4k+70ZGAzSE0JwvbOYBeKRBtS8z0KQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Pessoa_FornecedorId",
                table: "Compra",
                column: "FornecedorId",
                principalTable: "Pessoa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Pessoa_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Pessoa",
                principalColumn: "Id");
        }
    }
}
