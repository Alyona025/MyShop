using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Program
    {
        static void Main()
        {
            Shop shop = new Shop("Пятёрочка");

            shop.products.Add(new Product("Хлеб", 25, 10));
            shop.products.Add(new Product("Молоко", 80, 15));
            shop.products.Add(new Product("Сок", 130, 3));
            shop.products.Add(new Product("Пельмени", 100, 5));

            while (true)
            {
                foreach (Product product in shop.products)
                {
                    Console.WriteLine($"{product.Title} цена - {product.Price} рублей, {product.Count} штук, ID: {product.Id}");
                }
                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Введите количество: ");
                int count = int.Parse(Console.ReadLine());

                foreach (Product product in shop.products)
                {
                    if (id == product.Id)
                    {
                        
                        if (count < 0)
                        {
                            Console.WriteLine("Введите положительное число");
                            Console.ReadLine();
                        }
                        else if (count > product.Count)
                        {
                            Console.WriteLine("Нет столько товаров");
                            Console.ReadLine();
                        }
                        else
                        {
                            product.Count -= count;
                            break;
                        }
                        
                    }

                    
                }
                Console.Clear();
            }

        }
    }
}
