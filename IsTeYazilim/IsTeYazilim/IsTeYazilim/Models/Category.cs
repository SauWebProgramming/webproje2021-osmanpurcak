using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTeYazilim.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

    }
}
