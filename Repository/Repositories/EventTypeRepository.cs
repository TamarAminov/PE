using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class EventTypeRepository : IRepository<EventType>
    {
        private readonly IContext _context;
        public EventTypeRepository(IContext context)
        {
            this._context = context;
        }
        public EventType AddItem(EventType item)
        {
            _context.EventType.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.EventType.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<EventType> GetAll()
        {
            return _context.EventType.ToList();
        }

        public EventType GetById(int id)
        {

            return (EventType)_context.EventType.FirstOrDefault(x => x.EventTypeID == id);
        }

        public void UpdateItem(int id, EventType item)
        {
            var area = GetById(id);
            area.EventTypeName = item.EventTypeName;
            _context.save();
        }
    }
}
