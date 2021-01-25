using System;
using System.Collections.Generic;

namespace Ders04_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();


            Console.WriteLine("------------Elle------------");

            Console.WriteLine(product1.ProductName);
            productManager.Add(product1);
            Console.WriteLine(product2.ProductName);
            productManager.Add(product2);

            Console.WriteLine("------------List-------------");

            List<Product> products = new List<Product> {
                product1,
                product2
            };

            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName);
                productManager.Add(item);
            }

            Console.WriteLine("------------------------------");


            productManager.Topla2(3, 6);    //void

            int toplamaSonucu = productManager.Topla(3, 5);

            Console.WriteLine(toplamaSonucu * 2);

        }
    }
}
