using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User AllUser { get; set; }
        [ForeignKey("EventType")]
        public int EventTypeID { get; set; }
        public int TotalBudget { get; set; }
        public int GuestCount { get; set; }
       
    }
}
