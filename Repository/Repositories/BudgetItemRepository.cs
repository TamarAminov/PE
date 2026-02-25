using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    internal class BudgetItemRepository : IRepository<BudgetItem>
    {
        private readonly IContext _context;
        public BudgetItemRepository(IContext context)
        {
            this._context = context;
        }
        public BudgetItem AddItem(BudgetItem item)
        {
            _context.BudgetItems.ToList().Add(item);
            _context.save();
            return item;
        }

        public void DeleteItem(int id)
        {
            _context.BudgetItems.ToList().Remove(GetById(id));
            _context.save();
        }

        public List<BudgetItem> GetAll()
        {
            return _context.BudgetItems.ToList();
        }

        public BudgetItem GetById(int id)
        {
            return (BudgetItem)_context.BudgetItems.FirstOrDefault(X => X.BudgetItemID == id);
        }

        public void UpdateItem(int id, BudgetItem item)
        {
            var budgetItem = GetById(id);
            budgetItem.EventID = item.EventID;
            budgetItem.AllEvent = item.AllEvent;
            budgetItem.CategoryID = item.CategoryID;
            budgetItem.ActualAmount = item.ActualAmount;
            budgetItem.VendorID = item.VendorID;
            budgetItem.Vendor = item.Vendor;
            budgetItem.PlannedAmount = item.PlannedAmount;
            _context.save();
        }
    }
}
