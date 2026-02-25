using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class VendorAttributeDto
    {
        public string VendorAttributeName { get; set; }   // שם המאפיין (לדוגמה: "PricePerDish")
        public string Value { get; set; } // הערך (לדוגמה: "250")

        public int VendorId { get; set; }
        public string? VendorName { get; set; }
    }
}
