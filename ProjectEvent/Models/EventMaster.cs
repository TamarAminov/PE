using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEvent.Models
{
    public class EventMaster: DbContext, IContext
    {
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<BudgetItem> BudgetItems { get; set; }


        public virtual DbSet<Vendor> Vendors { get; set; }

        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<Category> Category { get; set; }




        IEnumerable<Event> IContext.Events => Events;
        IEnumerable<Vendor> IContext.Vendors => Vendors;

        IEnumerable<Tasks> IContext.Tasks => Tasks;

        IEnumerable<BudgetItem> IContext.BudgetItems => BudgetItems;

        IEnumerable<User> IContext.Users => Users;
        IEnumerable<Area> IContext.Area => Area;
        IEnumerable<VendorAttribute> IContext.VendorAttributes => VendorAttributes;
        IEnumerable<EventType> IContext.EventType => EventType;
        IEnumerable<Category> IContext.Category => Category;
     


        public void save()
        {
            SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=sql;database=EventDB;trusted_connection=true;TrustServerCertificate=True");
        }
    }
}

