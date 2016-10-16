using enterprise_gateway_demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace enterprise_gateway_demo
{
    public class Database:DbContext
    {
        public Database() : base() { }

        public DbSet<CustomerSegment> CustomerSegment { get; set; }
        public DbSet<DateDim> DateDim { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}