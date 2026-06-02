using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompany.Intranet.Migrations
{
    /// <inheritdoc />
    public partial class SeederFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 4, 22, 14, 53, 5, 226, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 4, 22, 14, 53, 5, 231, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2026, 4, 22, 14, 53, 5, 231, DateTimeKind.Local).AddTicks(303));
        }
    }
}
