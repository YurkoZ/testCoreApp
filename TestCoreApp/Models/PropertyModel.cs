using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class PropertyModel
    {
        public string ImgUrl { get; set; }
        public double CurrentPrice { get; set; }
        public double PriceChanges { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public int Photos { get; set; }
        public int Beds { get; set; }
        public double Bath { get; set; }
        public int SQFT { get; set; }
        public bool Favorite { get; set; }
        public DateTime SoldDate { get; set; }
        public string Represented { get; set; }
    }
}
