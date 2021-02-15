using GameSellingProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Concrate
{
    class SalesManager : ISalesService
    {
        public void Sell(Product product, Gamer gamer)
        {
            Console.WriteLine(product.ProductName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " adlı kullanıcıya " + product.UnitPrice + " fiyatla satıldı");
        }

        public void CampaignSale(Product product, Gamer gamer, Campaign campaign)
        {
            double discountedSale = product.UnitPrice - product.UnitPrice * campaign.CampaignRate;
            Console.WriteLine(product.ProductName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName + " adlı kullanıcıya " + campaign.CampaignName +
                              " kampanyası ile " + discountedSale + " fiyatla satıldı");
        }
    }
}
