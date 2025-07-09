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

            int profit = 0;
            while (true) //начинается цикл
            {
                Console.WriteLine($"Прибыль магазина {shop.Name}: {profit} рублей");
                Console.WriteLine();
                foreach (Product product in shop.products)
                {
                    Console.WriteLine($"{product.Title} цена - {product.Price} рублей, {product.Count} штук, ID: {product.Id}");
                }
                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Введите количество: ");
                int count = int.Parse(Console.ReadLine());

                bool found = false; // для проверки наличия товара 

                foreach (Product product in shop.products)
                {
                    if (id == product.Id)
                    {

                    found = true;

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
                            profit += product.Price * count;
                            product.Count -= count;
                            break;
                        }
                    }
                   
                }
                if (!found)
                {
                    Console.WriteLine("У магазина нет товара с таким ID");
                    Console.ReadLine();
                }
                Console.Clear();
            } //заканчивается цикл while.

        }
    }
}
