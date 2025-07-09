using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Shop
    {
        public List<Product> products = new List<Product>();
        public string Name;

        public Shop (string name)
        {
            Name=name;
        }
    }
}
