using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSync.Migrations
{
    /// <inheritdoc />
    public partial class fixessource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Email", "LastModified", "Name" },
                values: new object[] { "sapana@gmail.com", new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2800), "Sapana Shrestha" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 19,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 20,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 4,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 5,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 6,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 7,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 8,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 9,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 10,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 11,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 12,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 13,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 14,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 15,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 16,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 17,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 18,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 19,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 20,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 21,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 22,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 23,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 24,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 25,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 18, 18, 21, 433, DateTimeKind.Local).AddTicks(2926));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Email", "LastModified", "Name" },
                values: new object[] { "sagar@gmail.com", new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(186), "Sagar Thapa" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 19,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 20,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 4,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 5,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 6,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 7,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 8,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 9,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 10,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 11,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 12,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 13,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 14,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 15,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 16,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 17,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 18,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 19,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 20,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 21,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 22,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 23,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 24,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 25,
                column: "LastModified",
                value: new DateTime(2024, 10, 27, 16, 22, 42, 868, DateTimeKind.Local).AddTicks(433));
        }
    }
}
