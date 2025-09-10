using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PacotesPetShop.Migrations
{
    /// <inheritdoc />
    public partial class AjusteFkBanho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banhos_Clientes_ClienteIdCliente",
                table: "Banhos");

            migrationBuilder.DropIndex(
                name: "IX_Banhos_ClienteIdCliente",
                table: "Banhos");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Banhos");

            migrationBuilder.CreateIndex(
                name: "IX_Banhos_IdCliente",
                table: "Banhos",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Banhos_Clientes_IdCliente",
                table: "Banhos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banhos_Clientes_IdCliente",
                table: "Banhos");

            migrationBuilder.DropIndex(
                name: "IX_Banhos_IdCliente",
                table: "Banhos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Banhos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Banhos_ClienteIdCliente",
                table: "Banhos",
                column: "ClienteIdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Banhos_Clientes_ClienteIdCliente",
                table: "Banhos",
                column: "ClienteIdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
