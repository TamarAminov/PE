using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public  class BudgetItem
    {
        [Key]
        public int BudgetItemID {  get; set; }
        [ForeignKey("Event")]
        public string EventID { get; set; }
        public virtual Event AllEvent { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public int PlannedAmount { get; set; }
        public int ActualAmount { get; set; }
        [ForeignKey("Vendor")]
        public int VendorID { get; set; }

        public Vendor Vendor { get; set; }
    }
}
