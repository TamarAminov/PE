using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        public string BusinessName { get; set; }
        public int CategoryID { get; set; } // Catering, Photography...
        [ForeignKey("Area")]
        public int AreaID { get; set; } // צפון, מרכז, דרום
        public virtual Area Allarea { get; set; }
        public decimal BasePrice { get; set; } // מחיר התחלתי להשוואה


            // רשימת המאפיינים הייחודיים (מחיר מנה, כמות תמונות וכו')
        public List<VendorAttribute> Attributes { get; set; }
    }
    
}
