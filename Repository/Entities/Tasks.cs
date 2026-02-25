using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Tasks
    {
        [Key]
        public int TaskID { get; set; }

        [ForeignKey("Event")]
        public string EventID { get; set; }
        public virtual Event AllEvent { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateOnly DueDate { get; set; }
        [ForeignKey("Vendor")]
        public int VendorID { get; set; }

        public Vendor Vendor { get; set; }

    }
}
