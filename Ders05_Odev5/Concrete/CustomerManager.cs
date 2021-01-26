using Ders05_Odev5.Abstract;
using Ders05_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Concrete
{
    public class CustomerManager : IManagerService<Customer>
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("{0} {1} müşterisi eklendi...",entity.CustomerFirstName, entity.CustomerLastName);
        }
        public void Delete(Customer entity)
        {
            Console.WriteLine("{0} {1} müşterisi silindi...", entity.CustomerFirstName, entity.CustomerLastName);
        }   
        public void Update(Customer entity)
        {
            Console.WriteLine("{0} {1} müşterisi güncellendi...", entity.CustomerFirstName, entity.CustomerLastName);
        }
        public void Get(Customer entity)
        {
            Console.WriteLine("Müşteri Kimlik: {0} - Müşteri Adı: {1} - Müşteri Soyadı: {2}\n", entity.CustomerId, entity.CustomerFirstName, entity.CustomerLastName);
        }
        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("Müşteri Kimlik: {0} - Müşteri Adı: {1} - Müşteri Soyadı: {2}\n", item.CustomerId, item.CustomerFirstName, item.CustomerLastName);
            }
            Console.WriteLine();
        }

    }
}
