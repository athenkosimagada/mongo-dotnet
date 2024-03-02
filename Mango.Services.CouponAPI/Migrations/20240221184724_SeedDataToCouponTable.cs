using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToCouponTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "CreatedDate", "DiscountAmount", "MinAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "10OFF", new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3427), 10.0, 20, new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3428) },
                    { 2, "20OFF", new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3467), 20.0, 35, new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3467) },
                    { 3, "25OFF", new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3479), 40.0, 50, new DateTime(2024, 2, 21, 20, 47, 24, 340, DateTimeKind.Local).AddTicks(3479) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3);
        }
    }
}
