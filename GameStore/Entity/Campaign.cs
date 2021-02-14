using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entity
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
    }
}
