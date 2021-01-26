using Ders05_Odev5.Abstract;
using Ders05_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Concrete
{
    class CampaignManager : IManagerService<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("{0} kampanyası eklendi...",entity.CampaignName);
        }
        public void Delete(Campaign entity)
        {
            Console.WriteLine("{0} kampanyası silindi...", entity.CampaignName);
        }
        public void Update(Campaign entity)
        {
            Console.WriteLine("{0} kampanyası güncellendi...", entity.CampaignName);
        }
        public void Get(Campaign entity)
        {
            Console.WriteLine("Kampanya Kimlik: {0} - Kampanya Adı: {1} - İndirim Yüzdesi: {2}\n", entity.CampaignId,
                entity.CampaignName, entity.DiscountRate);
        }
        public void GetAll(List<Campaign> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("Kampanya Kimlik: {0} - Kampanya Adı: {1} - İndirim Yüzdesi: {2}\n", item.CampaignId,
                item.CampaignName, item.DiscountRate);
            }
            Console.WriteLine();
        }

    }
}
