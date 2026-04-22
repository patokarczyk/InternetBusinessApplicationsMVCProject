using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Intranet.Models.Warehouse;

namespace MyCompany.Intranet.Data
{
    public class MyCompanyIntranetContext : DbContext
    {
        public MyCompanyIntranetContext (DbContextOptions<MyCompanyIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Warehouse> Warehouse { get; set; } = default!;
        public DbSet<Supplier> Supplier { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Inventory> Inventory { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<OrderItem> OrderItem { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { IdCategory = 1, Name = "Electronics", Description = "Electronic devices" },
                new Category { IdCategory = 2, Name = "Food", Description = "Food products" },
                new Category { IdCategory = 3, Name = "Tools", Description = "Workshop tools" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { IdProduct = 1, Name = "Laptop", Description = "Gaming laptop", Price = 4500, IdCategory = 1 },
                new Product { IdProduct = 2, Name = "Bread", Description = "Whole grain bread", Price = 5.50m, IdCategory = 2 },
                new Product { IdProduct = 3, Name = "Hammer", Description = "Steel hammer", Price = 25.99m, IdCategory = 3 }
            );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { IdWarehouse = 1, Name = "Main Warehouse", Location = "Warsaw" },
                new Warehouse { IdWarehouse = 2, Name = "Backup Warehouse", Location = "Krakow" },
                new Warehouse { IdWarehouse = 3, Name = "Food Storage", Location = "Lodz" }
            );

            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { IdInventory = 1, IdProduct = 1, IdWarehouse = 1, Quantity = 10 },
                new Inventory { IdInventory = 2, IdProduct = 2, IdWarehouse = 3, Quantity = 200 },
                new Inventory { IdInventory = 3, IdProduct = 3, IdWarehouse = 2, Quantity = 50 }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { IdSupplier = 1, Name = "TechSupply", Phone = "111-222-333", Email = "tech@supply.com" },
                new Supplier { IdSupplier = 2, Name = "FoodCorp", Phone = "444-555-666", Email = "food@corp.com" },
                new Supplier { IdSupplier = 3, Name = "ToolMaster", Phone = "777-888-999", Email = "tools@master.com" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { IdOrder = 1, IdSupplier = 1, OrderDate = new DateTime(2022, 02, 02), Status = "New" },
                new Order { IdOrder = 2, IdSupplier = 2, OrderDate = new DateTime(2024, 04, 04), Status = "Delivered" },
                new Order { IdOrder = 3, IdSupplier = 3, OrderDate = new DateTime(2023, 03, 03), Status = "Pending" }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { IdOrderItem = 1, IdOrder = 1, IdProduct = 1, Quantity = 2, PurchasePrice = 4200 },
                new OrderItem { IdOrderItem = 2, IdOrder = 2, IdProduct = 2, Quantity = 100, PurchasePrice = 4.80m },
                new OrderItem { IdOrderItem = 3, IdOrder = 3, IdProduct = 3, Quantity = 10, PurchasePrice = 20 }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { IdEmployee = 1, FirstName = "John", LastName = "Smith", Position = "Manager", IdWarehouse = 1 },
                new Employee { IdEmployee = 2, FirstName = "Anna", LastName = "Kowalska", Position = "Worker", IdWarehouse = 2 },
                new Employee { IdEmployee = 3, FirstName = "Mike", LastName = "Brown", Position = "Supervisor", IdWarehouse = 3 }
            );
        }
    }
}
