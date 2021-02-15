using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Abstract
{
    public interface ISalesService
    {
        void Sell(Product product, Gamer gamer);
        void CampaignSale(Product product, Gamer gamer, Campaign campaign);
    }
}
