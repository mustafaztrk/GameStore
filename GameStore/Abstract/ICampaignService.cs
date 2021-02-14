using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
