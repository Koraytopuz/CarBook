using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_location_reservation_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Customers_CustomerID",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess");

            migrationBuilder.RenameTable(
                name: "RentACarProcess",
                newName: "RentACarsProcesses");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CustomerID",
                table: "RentACarsProcesses",
                newName: "IX_RentACarsProcesses_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CarID",
                table: "RentACarsProcesses",
                newName: "IX_RentACarsProcesses_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarsProcesses",
                table: "RentACarsProcesses",
                column: "RentACarProcessID");

            migrationBuilder.CreateTable(
                name: "Rezervations",
                columns: table => new
                {
                    RezervationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickUpLocationID = table.Column<int>(type: "int", nullable: true),
                    DropOffLocationID = table.Column<int>(type: "int", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DriverLicenceYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervations", x => x.RezervationID);
                    table.ForeignKey(
                        name: "FK_Rezervations_Locations_DropOffLocationID",
                        column: x => x.DropOffLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Rezervations_Locations_PickUpLocationID",
                        column: x => x.PickUpLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_DropOffLocationID",
                table: "Rezervations",
                column: "DropOffLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_PickUpLocationID",
                table: "Rezervations",
                column: "PickUpLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarsProcesses_Cars_CarID",
                table: "RentACarsProcesses",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarsProcesses_Customers_CustomerID",
                table: "RentACarsProcesses",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarsProcesses_Cars_CarID",
                table: "RentACarsProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarsProcesses_Customers_CustomerID",
                table: "RentACarsProcesses");

            migrationBuilder.DropTable(
                name: "Rezervations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarsProcesses",
                table: "RentACarsProcesses");

            migrationBuilder.RenameTable(
                name: "RentACarsProcesses",
                newName: "RentACarProcess");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarsProcesses_CustomerID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarsProcesses_CarID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess",
                column: "RentACarProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Customers_CustomerID",
                table: "RentACarProcess",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
