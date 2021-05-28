using Microsoft.EntityFrameworkCore;
using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.DataAccess
{
    public class OrderContext: DbContext
    {
        /*protected override void onconfiguring(dbcontextoptionsbuilder optionsbuilder)
        {
            optionsbuilder.usesqlserver(configurationmanager.connectionstrings["sqlconnection"].connectionstring);
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RUV2BAU;Initial Catalog=NorthWind;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .ToTable("Categories");
            modelBuilder.Entity<Categories>()
                .HasKey(category => category.CategoryID);

            modelBuilder.Entity<Customers>()
                .ToTable("Customers");
            modelBuilder.Entity<Customers>()
                .HasKey(c => c.CustomerID);

            modelBuilder.Entity<Employees>()
                .ToTable("Employees");
            modelBuilder.Entity<Employees>()
                .HasKey(e => e.EmployeeID);

            modelBuilder.Entity<Orders>()
                .ToTable("Orders");
            modelBuilder.Entity<Orders>()
                .HasKey(o => o.OrderID);

            modelBuilder.Entity<Products>()
                .ToTable("Products");
            modelBuilder.Entity<Products>()
                .HasKey(p=>p.ProductID);

            modelBuilder.Entity<OrderDetails>()
                .ToTable("Order Details");
            modelBuilder.Entity<OrderDetails>()
                .HasKey(od=>od.OrderID);
            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => od.ProductID);

            modelBuilder.Entity<Shippers>()
                .ToTable("Shippers");
            modelBuilder.Entity<Shippers>()
                .HasKey(s => s.ShipperID);

            modelBuilder.Entity<Suppliers>()
                .ToTable("Suppliers");
            modelBuilder.Entity<Suppliers>()
                .HasKey(s => s.SupplierID);

            modelBuilder.Entity<Region>()
                .ToTable("Region");
            modelBuilder.Entity<Region>()
                .HasKey(r=>r.RegionID);
        }
        public DbSet<Customers> customers { get; set; }

        public DbSet<Products> products { get; set; }

        public DbSet<Categories> categories { get; set; }

        public DbSet<Employees> employees { get; set; }

        public DbSet<OrderDetails> orderDetails { get; set; }

        public DbSet<Orders> orders { get; set; }

        public DbSet<Shippers> shippers { get; set; }

        public DbSet<Suppliers> suppliers { get; set; }

        public DbSet<Region> regions { get; set; }

        /*public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }*/

    }

}
