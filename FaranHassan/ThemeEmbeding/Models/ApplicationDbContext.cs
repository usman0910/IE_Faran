using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<StockIn> StockIns { get; set; }
        public DbSet<StockOut> StockOuts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}