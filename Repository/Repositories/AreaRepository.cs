using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class AreaRepository : IRepository<Area>
    {
        private readonly IContext _context;
        public AreaRepository(IContext context)
        {
            this._context = context;
        }
        public Area AddItem(Area item)
        {
            _context.Area.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.Area.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<Area> GetAll()
        {
            return _context.Area.ToList();
        }

        public Area GetById(int id)
        {

            return (Area)_context.Area.FirstOrDefault(x => x.AreaID == id);
        }

        public void UpdateItem(int id, Area item)
        {
            var area = GetById(id);
            area.AreaName = item.AreaName;
            _context.save();
        }
    }
}
