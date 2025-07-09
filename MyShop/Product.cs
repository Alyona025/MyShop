using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Product
    {
        public string Title;
        public int Price;
        public int Count;
        public int Id;
        private static int NextId = 0;

        public Product(string title, int price, int count)
        {
            Title = title;
            Price = price;
            Count = count;
            Id = NextId++;
        }



    }
}
