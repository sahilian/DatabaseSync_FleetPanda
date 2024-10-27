using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseSync.Migrations
{
    /// <inheritdoc />
    public partial class fixessource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Locations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Email", "LastModified", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "sapana@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9301), "Sapana Shrestha", "9811111111" },
                    { 2, "sahil@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9353), "Sahil Shrestha", "9822222222" },
                    { 3, "aayush@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9354), "Aayush Khadka", "9833333333" },
                    { 4, "sneha@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9355), "Sneha Sharma", "9844444444" },
                    { 5, "rajesh@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9356), "Rajesh Karki", "9855555555" },
                    { 6, "ramesh@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9357), "Ramesh Bhandari", "9866666666" },
                    { 7, "nabin@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9358), "Nabin Rijal", "9877777777" },
                    { 8, "sita@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9359), "Sita Rai", "9888888888" },
                    { 9, "pratiksha@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9360), "Pratiksha Joshi", "9899999999" },
                    { 10, "bikash@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9361), "Bikash Acharya", "9800000001" },
                    { 11, "santosh@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9362), "Santosh Yadav", "9800000002" },
                    { 12, "niraj@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9363), "Niraj Gurung", "9800000003" },
                    { 13, "kriti@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9364), "Kriti Maharjan", "9800000004" },
                    { 14, "binita@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9365), "Binita Kunwar", "9800000005" },
                    { 15, "saroj@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9366), "Saroj Luitel", "9800000006" },
                    { 16, "asmita@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9367), "Asmita Lama", "9800000007" },
                    { 17, "kiran@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9368), "Kiran Sapkota", "9800000008" },
                    { 18, "bhawana@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9369), "Bhawana Adhikari", "9800000009" },
                    { 19, "arjun@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9370), "Arjun Adhikari", "9800000010" },
                    { 20, "mina@gmail.com", new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9371), "Mina Magar", "9800000011" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Address", "CustomerID", "LastModified" },
                values: new object[,]
                {
                    { 1, "Kathmandu", 1, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9459) },
                    { 2, "Bhaktapur", 1, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9460) },
                    { 3, "Dang", 2, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9461) },
                    { 4, "Chitwan", 3, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9462) },
                    { 5, "Butwal", 3, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9463) },
                    { 6, "Dharan", 4, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9464) },
                    { 7, "Janakpur", 5, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9465) },
                    { 8, "Nepalgunj", 6, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9465) },
                    { 9, "Birgunj", 7, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9466) },
                    { 10, "Hetauda", 7, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9467) },
                    { 11, "Gorkha", 8, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9468) },
                    { 12, "Lamjung", 9, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9469) },
                    { 13, "Palpa", 10, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9470) },
                    { 14, "Syangja", 10, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9470) },
                    { 15, "Baglung", 11, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9471) },
                    { 16, "Damauli", 12, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9472) },
                    { 17, "Tanahun", 13, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9473) },
                    { 18, "Ilam", 14, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9474) },
                    { 19, "Jhapa", 15, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9475) },
                    { 20, "Kavre", 16, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9476) },
                    { 21, "Banepa", 16, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9477) },
                    { 22, "Sindhuli", 17, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9477) },
                    { 23, "Nuwakot", 18, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9478) },
                    { 24, "Ramechhap", 19, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9479) },
                    { 25, "Dolakha", 20, new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9480) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CustomerID",
                table: "Locations",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
