using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSync.Migrations.TargetDb
{
    /// <inheritdoc />
    public partial class fixestarget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Customers_TargetCustomerCustomerID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Locations_CustomerID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_TargetCustomerCustomerID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "TargetCustomerCustomerID",
                table: "Locations");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Customers_CustomerID",
                table: "Locations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Customers_CustomerID",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "TargetCustomerCustomerID",
                table: "Locations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_TargetCustomerCustomerID",
                table: "Locations",
                column: "TargetCustomerCustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Customers_TargetCustomerCustomerID",
                table: "Locations",
                column: "TargetCustomerCustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Locations_CustomerID",
                table: "Locations",
                column: "CustomerID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
