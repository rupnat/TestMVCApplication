using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestMVCApplication.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestMVCApplication.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Customer>()
            //.HasOptional<Order>(m => m.Orders)
            //.WithRequired(m => m.Member)
            //.Map(p => p.MapKey("MemberId"));
        }

        public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<Order_Detail> Order_Details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}