using Ders05_Odev5.Abstract;
using Ders05_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Concrete
{
    public class SalesManager:Campaign
    {       
        public void ApplyDiscount(Product product, Campaign campaign)
        {
            double unitPrice = Convert.ToDouble(product.ProductUnitPrice);
            double discountedRate = Convert.ToDouble(campaign.DiscountRate);

            unitPrice = unitPrice - unitPrice * discountedRate;

            Console.WriteLine("Oyun : {0} - Birim Fiyatı: {1}\nKampanya Adı:  {2} - İndirim Oranı:  {3} --> İndirimli Fiyatı:  {4}\n",
                    product.ProductName, product.ProductUnitPrice, campaign.CampaignName, campaign.DiscountRate, unitPrice);
        }

        IManagerService<Product> manager = new ProductManager();
        public decimal ApplyDiscount(List<Product> productList, Campaign campaign)
        {
            double total = 0;
            double discountedAmount = 0;

            manager.GetAll(productList);

            for (int i = 0; i < productList.Count; i++)
            {
                total = total + (double)productList[i].ProductUnitPrice;
               
                discountedAmount = total - total * (double)campaign.DiscountRate;
            }

            Console.WriteLine("Total Amount:  {0}\nDiscounted Amount:  {1:F}\n", total, discountedAmount);

            return (decimal)discountedAmount;
        }
    }
}
