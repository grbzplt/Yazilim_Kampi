using Ders05_Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }

    }
}
