using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseSync.Migrations
{
    /// <inheritdoc />
    public partial class InitialSource : Migration
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
                    { 1, "sagar@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(186), "Sagar Thapa", "9811111111" },
                    { 2, "sahil@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(197), "Sahil Shrestha", "9822222222" },
                    { 3, "aayush@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(198), "Aayush Khadka", "9833333333" },
                    { 4, "sneha@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(199), "Sneha Sharma", "9844444444" },
                    { 5, "rajesh@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(200), "Rajesh Karki", "9855555555" },
                    { 6, "ramesh@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(201), "Ramesh Bhandari", "9866666666" },
                    { 7, "nabin@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(202), "Nabin Rijal", "9877777777" },
                    { 8, "sita@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(202), "Sita Rai", "9888888888" },
                    { 9, "pratiksha@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(203), "Pratiksha Joshi", "9899999999" },
                    { 10, "bikash@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(204), "Bikash Acharya", "9800000001" },
                    { 11, "santosh@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(265), "Santosh Yadav", "9800000002" },
                    { 12, "niraj@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(266), "Niraj Gurung", "9800000003" },
                    { 13, "kriti@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(267), "Kriti Maharjan", "9800000004" },
                    { 14, "binita@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(268), "Binita Kunwar", "9800000005" },
                    { 15, "saroj@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(269), "Saroj Luitel", "9800000006" },
                    { 16, "asmita@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(270), "Asmita Lama", "9800000007" },
                    { 17, "kiran@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(271), "Kiran Sapkota", "9800000008" },
                    { 18, "bhawana@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(272), "Bhawana Adhikari", "9800000009" },
                    { 19, "arjun@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(273), "Arjun Adhikari", "9800000010" },
                    { 20, "mina@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(273), "Mina Magar", "9800000011" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Address", "CustomerID", "LastModified" },
                values: new object[,]
                {
                    { 1, "Kathmandu", 1, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(411) },
                    { 2, "Bhaktapur", 1, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(412) },
                    { 3, "Dang", 2, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(413) },
                    { 4, "Chitwan", 3, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(414) },
                    { 5, "Butwal", 3, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(415) },
                    { 6, "Dharan", 4, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(416) },
                    { 7, "Janakpur", 5, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(417) },
                    { 8, "Nepalgunj", 6, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(418) },
                    { 9, "Birgunj", 7, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(419) },
                    { 10, "Hetauda", 7, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(419) },
                    { 11, "Gorkha", 8, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(420) },
                    { 12, "Lamjung", 9, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(421) },
                    { 13, "Palpa", 10, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(422) },
                    { 14, "Syangja", 10, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(423) },
                    { 15, "Baglung", 11, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(424) },
                    { 16, "Damauli", 12, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(425) },
                    { 17, "Tanahun", 13, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(426) },
                    { 18, "Ilam", 14, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(426) },
                    { 19, "Jhapa", 15, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(427) },
                    { 20, "Kavre", 16, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(428) },
                    { 21, "Banepa", 16, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(429) },
                    { 22, "Sindhuli", 17, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(430) },
                    { 23, "Nuwakot", 18, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(431) },
                    { 24, "Ramechhap", 19, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(432) },
                    { 25, "Dolakha", 20, new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(433) }
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
