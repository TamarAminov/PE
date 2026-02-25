using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class VendorDto
    {
        public string BusinessName { get; set; }
        public int CategoryID { get; set; } // Catering, Photography...
        public string CategoryName { get; set; } // Catering, Photography...
        public int AreaId { get; set; }
        public string AreaName { get; set; } // צפון, מרכז, דרום
        public decimal BasePrice { get; set; } // מחיר התחלתי להשוואה


        // רשימת המאפיינים הייחודיים (מחיר מנה, כמות תמונות וכו')
        public List<VendorAttributeDto> Attributes { get; set; }
    }
}
