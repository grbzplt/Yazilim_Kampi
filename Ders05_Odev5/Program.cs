using System;
using System.Collections.Generic;
using Ders05_Odev5.Entities;
using Ders05_Odev5.Concrete;
using Ders05_Odev5.Abstract;

namespace Ders05_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Müşteri TcNo Kontrolü ------------");

            CustomerTcNoControlService customerTcNoControlService = new CustomerTcNoControlService(new Customer
            {
                CustomerId = 1,
                CustomerFirstName = "Gürbüz",
                CustomerLastName = "Polat",
                BirthofYear = 1959,
                TcNo = "12345678900"
            }) ;

            Customer customer1 = new Customer { CustomerId = 101, CustomerFirstName = "Ahmet", CustomerLastName = "Mert", BirthofYear = 2001,TcNo="12345678901"};
            Customer customer2 = new Customer { CustomerId = 102, CustomerFirstName = "Hakan", CustomerLastName = "Uyar", BirthofYear = 2002, TcNo = "12345678902" };
            Customer customer3 = new Customer { CustomerId = 103, CustomerFirstName = "Zeynep", CustomerLastName = "Gencel", BirthofYear = 2003, TcNo = "12345678903" };


            Product product1 = new Product { ProductId = 1, ProductName = "Oyun-1 2018", ProductUnitPrice = 20 };
            Product product2 = new Product { ProductId = 2, ProductName = "Oyun-2 2020", ProductUnitPrice = 50 };
            Product product3 = new Product { ProductId = 3, ProductName = "Oyun-3 2019", ProductUnitPrice = 40 };
           

            Campaign campaign1 = new Campaign { CampaignId = 10, CampaignName = "Oyun-1 2018", DiscountRate = 0.4 };
            Campaign campaign2 = new Campaign { CampaignId = 11, CampaignName = "Oyun-2 2020", DiscountRate = 0.1 };
            Campaign campaign3 = new Campaign { CampaignId = 12, CampaignName = "Oyun-3 2019", DiscountRate = 0.25 };


            IManagerService<Customer> customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();

            Console.WriteLine("");
            Console.WriteLine("------------ Oyuncular -------------------");

            List<Customer> customerList = new List<Customer> { customer1, customer2, customer3 };

            customerManager.GetAll(customerList);


            Console.WriteLine("------------ Oyunlar ---------------------");

            List<Product> productList = new List<Product> { product1, product2, product3 };

            productManager.GetAll(productList);


            Console.WriteLine("------------ Kampanyalar -------------------");

            List<Campaign> campaignList = new List<Campaign> { campaign1, campaign2, campaign3 };

            campaignManager.GetAll(campaignList);


            Console.WriteLine("--------------- Oyuncu ekleme,silme,güncelleme ------------------");

            Customer customer4 = new Customer { CustomerId = 12, CustomerFirstName = "Gökhan", CustomerLastName = "Genç", BirthofYear = 2004, TcNo = "12345678904" };
            customerManager.Add(customer4);

            customerManager.Delete(customer3);

            customerManager.Delete(customer2);
            Customer customer5 = new Customer { CustomerId = 11, CustomerFirstName = "Ahmet Hakan", CustomerLastName = "Uyar", BirthofYear = 2002, TcNo = "12345678905" };
            customerManager.Update(customer5);

            Console.WriteLine("");
            Console.WriteLine("--------------- Oyun ekleme,silme,güncelleme ------------------");

            Product product4 = new Product { ProductId = 4, ProductName = "Oyun-4 2021", ProductUnitPrice = 80 };
            productManager.Add(product4);

            productManager.Delete(product1);

            productManager.Update(product2);

            Console.WriteLine("");
            Console.WriteLine("--------------------- Kampanya güncelleme ---------------------");

            campaignManager.Update(campaign2);


            Console.WriteLine("");
            Console.WriteLine("---------------------- Tek ürüne indirim uygulama -----------------------");

            salesManager.ApplyDiscount(product2, campaign3);

            Console.WriteLine("");
            Console.WriteLine("---------------------- Tüm ürünleri alana indirim uygulama -----------------------");

            salesManager.ApplyDiscount(productList, campaign3);
            
        }
    }
}
