using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class ClienteIdFieldSetToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 522, DateTimeKind.Local).AddTicks(260),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 522, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 519, DateTimeKind.Local).AddTicks(5859),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 520, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Venda",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 552, DateTimeKind.Local).AddTicks(8467),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 552, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 517, DateTimeKind.Local).AddTicks(8917),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 518, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 516, DateTimeKind.Local).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 516, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 515, DateTimeKind.Local).AddTicks(7101),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 514, DateTimeKind.Local).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 513, DateTimeKind.Local).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 514, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 510, DateTimeKind.Local).AddTicks(9683),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 511, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 504, DateTimeKind.Local).AddTicks(5062),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 505, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 499, DateTimeKind.Local).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 500, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 489, DateTimeKind.Local).AddTicks(6185),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 491, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 547, DateTimeKind.Local).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 546, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 545, DateTimeKind.Local).AddTicks(9458),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 545, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 541, DateTimeKind.Local).AddTicks(2781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 541, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 539, DateTimeKind.Local).AddTicks(2613),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 539, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 537, DateTimeKind.Local).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 538, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 535, DateTimeKind.Local).AddTicks(3133),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 535, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 526, DateTimeKind.Local).AddTicks(2826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 526, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 527, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 527, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 525, DateTimeKind.Local).AddTicks(549),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 525, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 523, DateTimeKind.Local).AddTicks(6769),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 523, DateTimeKind.Local).AddTicks(7706));

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
                column: "ConcurrencyStamp",
                value: "841ee490-a971-420e-bee2-18e493360918");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "ff9af3ab-10f1-4f13-a1e7-3a1f6ae72942");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a163f29b-6358-4539-8b97-918c3d48053f", "AQAAAAEAACcQAAAAEGVQ/uXtq8SmzVNTVjVhXqcYA18dfsKgj86t4k+70ZGAzSE0JwvbOYBeKRBtS8z0KQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 522, DateTimeKind.Local).AddTicks(2818),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 522, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 520, DateTimeKind.Local).AddTicks(1470),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 519, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Venda",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 552, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 552, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 518, DateTimeKind.Local).AddTicks(3863),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 517, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoPessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 516, DateTimeKind.Local).AddTicks(9998),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 516, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(9878),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 515, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provincia",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 515, DateTimeKind.Local).AddTicks(838),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 514, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 514, DateTimeKind.Local).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 513, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 511, DateTimeKind.Local).AddTicks(4891),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 510, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 505, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 504, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Municipio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 500, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 499, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 491, DateTimeKind.Local).AddTicks(1037),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 489, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 546, DateTimeKind.Local).AddTicks(9718),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 547, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 545, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 545, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 541, DateTimeKind.Local).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 541, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 539, DateTimeKind.Local).AddTicks(6224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 539, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comuna",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 538, DateTimeKind.Local).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 537, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 535, DateTimeKind.Local).AddTicks(7331),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 535, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 526, DateTimeKind.Local).AddTicks(3232),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 526, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 527, DateTimeKind.Local).AddTicks(8997),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 527, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 525, DateTimeKind.Local).AddTicks(642),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 525, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 14, 3, 47, 523, DateTimeKind.Local).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 14, 14, 7, 28, 523, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "2fd838c7-ea9f-4712-9355-7faabd810589");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "010e7c45-6191-4b62-9c46-e3f2ad4e8d74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "cacb1921-771f-44f0-af32-2f318a458872");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "aa63dd13-1a48-457d-b27f-8ae6acc39ac2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ConcurrencyStamp",
                value: "4bf809e8-9261-4b58-853a-7d94fe9709e6");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ea4fdc9-d169-44eb-8565-a3f5f7090ac7", "AQAAAAEAACcQAAAAEICI+55BFItN4uOVqGYWX23dREGK3iK21ARKBQZ64JMMJb0g0OQnYhWkzmgVV66LyQ==" });
        }
    }
}
