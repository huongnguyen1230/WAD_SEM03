using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_SEM3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; } // khoa ngoai

        public virtual Category Category { get; set; }
    }
}