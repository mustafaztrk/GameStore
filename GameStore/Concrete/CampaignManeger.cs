using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{

    class CampaignManeger : ICampaignService
    {
        private IEntity _campaign;
        List<Campaign> campaigns;
        public CampaignManeger(Campaign campaign)
        {
            _campaign = campaign;
            campaigns = new List<Campaign>();
        }
        public void Add(Campaign _campaign)
        {
            campaigns.Add(_campaign);
        }

        public void Delete(Campaign _campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign _campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }

        public void ShowCampaign()
        {
            foreach (var item in campaigns)
            {
                Console.WriteLine(item.CampaignName);
            }
        }
    }
}
