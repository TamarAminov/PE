using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class VendorAttributeRepository : IRepository<VendorAttribute>
    {
        private readonly IContext _context;
        public VendorAttributeRepository(IContext context)
        {
            this._context = context;
        }
        public VendorAttribute AddItem(VendorAttribute item)
        {
            _context.VendorAttributes.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.VendorAttributes.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<VendorAttribute> GetAll()
        {
            return _context.VendorAttributes.ToList();
        }

        public VendorAttribute GetById(int id)
        {
            return (VendorAttribute)_context.VendorAttributes.FirstOrDefault(x => x.VendorAttributeID == id);

        }

        public void UpdateItem(int id, VendorAttribute item)
        {
            var vendorAttribute = GetById(id);
            vendorAttribute.Value=item.Value;
            vendorAttribute.VendorId = item.VendorId;
            vendorAttribute.Vendor=item.Vendor;
            vendorAttribute.VendorAttributeName = item.VendorAttributeName;
            _context.save();
        }
    }
}
