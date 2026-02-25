using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class VendorRepository : IRepository<Vendor>
    {
        private readonly IContext _context;
        public VendorRepository(IContext context)
        {
            this._context = context;
        }
        public Vendor AddItem(Vendor item)
        {
            _context.Vendors.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.Vendors.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetById(int id)
        {
            return (Vendor)_context.Vendors.FirstOrDefault(X => X.VendorID == id);
        }

        public void UpdateItem(int id, Vendor item)
        {
            var vendor = GetById(id);
            vendor.BasePrice = item.BasePrice;
            vendor.BusinessName = item.BusinessName;
            vendor.AreaID = item.AreaID;
            vendor.CategoryID = item.CategoryID;
            vendor.Attributes = item.Attributes;
            _context.save();
        }
    }
}
