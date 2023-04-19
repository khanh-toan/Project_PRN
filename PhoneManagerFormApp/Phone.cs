using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerFormApp
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
 
        public int ManufacturerId { get; set; }

        public string ManufacturerName { get; set; }
       public int Quantity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

        public string Country { get; set; } 
    }
}
