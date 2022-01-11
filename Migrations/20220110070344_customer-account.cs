using Microsoft.EntityFrameworkCore.Migrations;

namespace FinancialPortal.Migrations
{
    public partial class customeraccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAccounts_CustomerAccountId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerAccountId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CustomerAccountId",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerAccountId",
                table: "Customers",
                column: "CustomerAccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAccounts_CustomerAccountId",
                table: "Customers",
                column: "CustomerAccountId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
