using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyCompany.Intranet.Migrations
{
    /// <inheritdoc />
    public partial class OrdersAndOrderItemAndSeederMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    IdOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSupplier = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Order_Supplier_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "Supplier",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    IdOrderItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrder = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.IdOrderItem);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Order",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Electronic devices", "Electronics" },
                    { 2, "Food products", "Food" },
                    { 3, "Workshop tools", "Tools" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "IdSupplier", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "tech@supply.com", "TechSupply", "111-222-333" },
                    { 2, "food@corp.com", "FoodCorp", "444-555-666" },
                    { 3, "tools@master.com", "ToolMaster", "777-888-999" }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "IdWarehouse", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Warsaw", "Main Warehouse" },
                    { 2, "Krakow", "Backup Warehouse" },
                    { 3, "Lodz", "Food Storage" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "IdEmployee", "FirstName", "IdWarehouse", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, "John", 1, "Smith", "Manager" },
                    { 2, "Anna", 2, "Kowalska", "Worker" },
                    { 3, "Mike", 3, "Brown", "Supervisor" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "IdSupplier", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 4, 22, 14, 53, 5, 226, DateTimeKind.Local).AddTicks(9937), "New" },
                    { 2, 2, new DateTime(2026, 4, 22, 14, 53, 5, 231, DateTimeKind.Local).AddTicks(276), "Delivered" },
                    { 3, 3, new DateTime(2026, 4, 22, 14, 53, 5, 231, DateTimeKind.Local).AddTicks(303), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "IdProduct", "Description", "IdCategory", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Gaming laptop", 1, "Laptop", 4500m },
                    { 2, "Whole grain bread", 2, "Bread", 5.50m },
                    { 3, "Steel hammer", 3, "Hammer", 25.99m }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "IdInventory", "IdProduct", "IdWarehouse", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 10 },
                    { 2, 2, 3, 200 },
                    { 3, 3, 2, 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "IdOrderItem", "IdOrder", "IdProduct", "PurchasePrice", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 4200m, 2 },
                    { 2, 2, 2, 4.80m, 100 },
                    { 3, 3, 3, 20m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdSupplier",
                table: "Order",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_IdOrder",
                table: "OrderItem",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_IdProduct",
                table: "OrderItem",
                column: "IdProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "IdEmployee",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "IdEmployee",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "IdEmployee",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "IdInventory",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "IdInventory",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "IdInventory",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "IdSupplier",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "IdSupplier",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "IdSupplier",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "IdWarehouse",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "IdWarehouse",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "IdWarehouse",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: 3);
        }
    }
}
