using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Cars_CarID",
                table: "RentACarProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Customers_CustomerID",
                table: "RentACarProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "RentACarProcesses",
                newName: "RentACarProcess");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_CustomerID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_CarID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess",
                column: "RentACarProcessID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Customer_CustomerID",
                table: "RentACarProcess",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Customer_CustomerID",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "RentACarProcess",
                newName: "RentACarProcesses");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CustomerID",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CarID",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses",
                column: "RentACarProcessID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Cars_CarID",
                table: "RentACarProcesses",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Customers_CustomerID",
                table: "RentACarProcesses",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
