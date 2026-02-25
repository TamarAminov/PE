using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class EventDto
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int UserID { get; set; }
        public string EventTypeName { get; set; }
        public int TotalBudget { get; set; }
        public int GuestCount { get; set; }
    }
}
