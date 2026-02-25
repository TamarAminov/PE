using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class CategoryRepository : IRepository<Category>
    {
        private readonly IContext _context;
        public CategoryRepository(IContext context)
        {
            this._context = context;
        }
        public Category AddItem(Category item)
        {
            _context.Category.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.Category.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetById(int id)
        {
            return (Category)_context.Category.FirstOrDefault(X => X.CategoryID == id);
        }

        public void UpdateItem(int id, Category item)
        {
            var category = GetById(id);
            category.CategoryName = item.CategoryName;
            _context.save();
        }
    }
}
