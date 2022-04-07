using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel
{
    class Product
    {
        public float Cost { get; set;}
        public string Name { get; set;}

        public Product(float cost,string name)
        {
            Cost = cost;
            Name = name;
        }


    }
}
