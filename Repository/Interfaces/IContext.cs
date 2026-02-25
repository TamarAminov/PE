using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IContext
    {
        public IEnumerable<User> Users { get; }
        public IEnumerable<Event> Events { get; }
        public IEnumerable<Vendor> Vendors { get; }

        public IEnumerable<Tasks> Tasks { get; }
        public IEnumerable<BudgetItem> BudgetItems { get; }
        public IEnumerable<Area> Area { get; }
        public IEnumerable<VendorAttribute> VendorAttributes { get; }
        public IEnumerable<EventType> EventType { get; }
        public IEnumerable<Category> Category { get; }
       


        public void save();
    }
}
