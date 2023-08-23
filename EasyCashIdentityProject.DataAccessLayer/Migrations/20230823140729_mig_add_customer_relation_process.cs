using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_customer_relation_process : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerReceiverId",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerSenderId",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_CustomerReceiverId",
                table: "CustomerAccountProcesses",
                column: "CustomerReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_CustomerSenderId",
                table: "CustomerAccountProcesses",
                column: "CustomerSenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerReceiverId",
                table: "CustomerAccountProcesses",
                column: "CustomerReceiverId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerSenderId",
                table: "CustomerAccountProcesses",
                column: "CustomerSenderId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_CustomerSenderId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_CustomerReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_CustomerSenderId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "CustomerReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "CustomerSenderId",
                table: "CustomerAccountProcesses");
        }
    }
}
