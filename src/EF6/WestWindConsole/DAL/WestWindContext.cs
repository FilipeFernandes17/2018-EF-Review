﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    //My database context class is a "virtual representation"
    //of the database, with each DbSet<T> property referencing
    //a particular table in the database
    //it inherits from the DbContext class.
    public class WestWindContext : DbContext
    {
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            //Tell EF that it should NOT create any tables 
            //in the database on my behalf 
            //(null == no intitalizer)
            //This is an example of disabling database
            //initialization programmatically.
            Database.SetInitializer<WestWindContext>(null);
            //An alternative to this would be to disable database
            //intialization in the .configfile
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        // TODO: Practice - Add entities and DbSet<> properties for the remaining tables


    }
}
