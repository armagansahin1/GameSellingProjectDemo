using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Abstract;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Concrate
{
    class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellendi");
        }
    }
}
