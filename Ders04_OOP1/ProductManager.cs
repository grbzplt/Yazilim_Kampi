using System;
using System.Collections.Generic;
using System.Text;

namespace Ders04_OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi...");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi...");
        }
        public void Add(List<Product> product)
        {
            Console.WriteLine("Ürün eklendi...");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }
}
