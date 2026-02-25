using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class EventRepository : IRepository<Event>
    {
        private readonly IContext _context;
        public EventRepository(IContext context)
        {
            this._context = context;
        }
        public Event AddItem(Event item)
        {
            _context.Events.ToList().Add(item);
            _context.save();
            return item;
        }
        public void DeleteItem(int id)
        {
            _context.Events.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<Event> GetAll()
        {
           return _context.Events.ToList();
        }

        public Event GetById(int id)
        {
            return (Event)_context.Events.FirstOrDefault(x => x.EventID == id);
        }

        public void UpdateItem(int id, Event item)
        {
            var event1 = GetById(id);
            event1.EventDate  = item.EventDate;
            event1.EventName = item.EventName;
            event1.EventTypeID = item.EventTypeID;
            event1.UserID = item.UserID;
            event1.AllUser = item.AllUser;
            event1.GuestCount = item.GuestCount;
            event1.TotalBudget = item.TotalBudget;
            _context.save();
        }
    
    }
}
