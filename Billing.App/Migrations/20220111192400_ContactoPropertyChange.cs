using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.App.Migrations
{
    public partial class ContactoPropertyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contaco",
                table: "Contacto",
                newName: "Valor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 249, DateTimeKind.Local).AddTicks(6461),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 873, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 248, DateTimeKind.Local).AddTicks(4646),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 871, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 227, DateTimeKind.Local).AddTicks(2912),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 846, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 247, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 870, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 246, DateTimeKind.Local).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 869, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 868, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 867, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 244, DateTimeKind.Local).AddTicks(5833),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 866, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 243, DateTimeKind.Local).AddTicks(3581),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 865, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(8565),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 864, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 214, DateTimeKind.Local).AddTicks(9073),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 829, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(522),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 863, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 241, DateTimeKind.Local).AddTicks(5200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 862, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 240, DateTimeKind.Local).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 860, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 239, DateTimeKind.Local).AddTicks(2714),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 859, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 237, DateTimeKind.Local).AddTicks(7174),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 857, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 236, DateTimeKind.Local).AddTicks(1774),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 856, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 235, DateTimeKind.Local).AddTicks(6962),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 856, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 223, DateTimeKind.Local).AddTicks(5046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 841, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 222, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 840, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 220, DateTimeKind.Local).AddTicks(5246),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 837, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 219, DateTimeKind.Local).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 837, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 217, DateTimeKind.Local).AddTicks(2744),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 833, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 195, DateTimeKind.Local).AddTicks(2315),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 806, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 216, DateTimeKind.Local).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 832, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 215, DateTimeKind.Local).AddTicks(5777),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 831, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.AlterColumn<long>(
                name: "EstabelecimentoId",
                table: "Compra",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 213, DateTimeKind.Local).AddTicks(265),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 827, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(6),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 822, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(8613),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 823, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 207, DateTimeKind.Local).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 821, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 206, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 820, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 211, DateTimeKind.Local).AddTicks(851),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 825, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ced68d-1ba5-4490-8e89-0f151345c468", "AQAAAAEAACcQAAAAEPRvx0Zbxhk9HW+LK8COdY7N26jzv3F3ioH2sSVYFAHJjbEj55OAV03rE1tHjHcD7Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Contacto",
                newName: "Contaco");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VendaItem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 873, DateTimeKind.Local).AddTicks(321),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 249, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Venda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 871, DateTimeKind.Local).AddTicks(5526),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 248, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Usuario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 846, DateTimeKind.Local).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 227, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Titulo",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 870, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 247, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoVenda",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 869, DateTimeKind.Local).AddTicks(2862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 246, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoProduto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 868, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoFactura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 867, DateTimeKind.Local).AddTicks(3559),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 245, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoEntidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 866, DateTimeKind.Local).AddTicks(3811),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 244, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoContacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 865, DateTimeKind.Local).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 243, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 864, DateTimeKind.Local).AddTicks(6059),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seccao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 829, DateTimeKind.Local).AddTicks(9476),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 214, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Regime",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 863, DateTimeKind.Local).AddTicks(4465),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 242, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoMotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 862, DateTimeKind.Local).AddTicks(3905),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 241, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProdutoImagem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 860, DateTimeKind.Local).AddTicks(8940),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 240, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Produto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 859, DateTimeKind.Local).AddTicks(4627),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 239, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pessoa",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 857, DateTimeKind.Local).AddTicks(9862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 237, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Pais",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 856, DateTimeKind.Local).AddTicks(6923),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 236, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MotivoIsencao",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 856, DateTimeKind.Local).AddTicks(1727),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 235, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genero",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 841, DateTimeKind.Local).AddTicks(2776),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 223, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Funcionario",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 840, DateTimeKind.Local).AddTicks(5352),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 222, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FormaPagamento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 837, DateTimeKind.Local).AddTicks(9858),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 220, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Factura",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 837, DateTimeKind.Local).AddTicks(1397),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 219, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Estabelecimento",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 833, DateTimeKind.Local).AddTicks(9942),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 217, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Entidade",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 806, DateTimeKind.Local).AddTicks(9873),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 195, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 832, DateTimeKind.Local).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 216, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacto",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 831, DateTimeKind.Local).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 215, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.AlterColumn<long>(
                name: "EstabelecimentoId",
                table: "Compra",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Compra",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 827, DateTimeKind.Local).AddTicks(1526),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 213, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessageAttachment",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 822, DateTimeKind.Local).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatMessage",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 823, DateTimeKind.Local).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 208, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 821, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 207, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categoria",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 820, DateTimeKind.Local).AddTicks(9487),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 206, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Armazem",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 4, 20, 53, 17, 825, DateTimeKind.Local).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 1, 11, 20, 24, 0, 211, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31d6a915-f57a-4008-93b1-dba11a8d6309", "AQAAAAEAACcQAAAAEPDb24FO/BOopCOriB+rgN2YVSegujcAz4k3s2IJ0/NWnJcoY9SHBk7fcbVOGxOoZQ==" });
        }
    }
}
