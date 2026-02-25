using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class TasksDto
    {

        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateOnly DueDate { get; set; }
        public int VendorID { get; set; }
        public string EventID { get; set; }     

        public string? VendorName { get; set; }

    }
}
