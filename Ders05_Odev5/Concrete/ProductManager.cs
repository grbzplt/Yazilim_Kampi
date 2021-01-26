using Ders05_Odev5.Abstract;
using Ders05_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Concrete
{
    public class ProductManager : IManagerService<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine("{0} ürünü eklendi...", entity.ProductName);
        }
        public void Delete(Product entity)
        {
            Console.WriteLine("{0} ürünü silindi...", entity.ProductName);
        }      
        public void Update(Product entity)
        {
            Console.WriteLine("{0} ürünü güncellendi...", entity.ProductName);
        }
        public void Get(Product entity)
        {
            Console.WriteLine("Ürün Kimlik: {0} - Ürün Adı: {1} - Ürün Fiyatı: {2}\n", entity.ProductId, entity.ProductName, entity.ProductUnitPrice);
        }
        public void GetAll(List<Product> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("Ürün Kimlik: {0} - Ürün Adı: {1} - Ürün Fiyatı: {2}\n", item.ProductId, item.ProductName, item.ProductUnitPrice);
            }
            Console.WriteLine();
        }
    }
}
