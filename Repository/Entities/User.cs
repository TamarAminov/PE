using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPasswordHash { get; set; }
        public string UserPhone { get; set; } 
  
        public ICollection<Event>? UserEvents { get; set; }
            
    }
}
