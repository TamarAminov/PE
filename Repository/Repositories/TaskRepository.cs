using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class TaskRepository : IRepository<Tasks>
    {
        private readonly IContext _context;
        public TaskRepository(IContext context)
        {
            this._context = context;
        }
        public Tasks AddItem(Tasks item)
        {
            _context.Tasks.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.Tasks.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<Tasks> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public Tasks GetById(int id)
        {
            return (Tasks)_context.Tasks.FirstOrDefault(x => x.TaskID == id);

        }

        public void UpdateItem(int id, Tasks item)
        {
            var tasks = GetById(id);
            tasks.Description = item.Description;
            tasks.Vendor = item.Vendor;
            tasks.DueDate = item.DueDate;
            tasks.VendorID = item.VendorID;
            tasks.EventID = item.EventID;
            tasks.AllEvent= item.AllEvent;
            tasks.IsCompleted= item.IsCompleted;
            _context.save();
        }
    }
}
