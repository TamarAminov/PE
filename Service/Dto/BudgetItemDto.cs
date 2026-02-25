using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class BudgetItemDto
    {
        public string EventName { get; set; }
        public string CategoryName { get; set; }
        public int PlannedAmount { get; set; }
        public int ActualAmount { get; set; }

        public string VendorName { get; set; }
    }
}
