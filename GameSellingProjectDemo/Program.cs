using System;
using GameSellingProjectDemo.Abstract;
using GameSellingProjectDemo.Concrate;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
                { DateOfBirth = new DateTime(1995, 5, 19), FirstName = "ARMAĞAN", LastName = "ŞAHİN", Id = 1, NationalityId = "11189245922" };
            BaseGamerManager gamerManager = new GamerManager(new PersonCheckManager());
            gamerManager.Save(gamer);

            Campaign campaign = new Campaign { CampaignName = "%20 indirim", CampaignRate = 0.2 };

            Product product1 = new Product { Id = 1, ProductName = "Assassin's Creed", UnitPrice = 150 };
            Product product2 = new Product { Id = 2, ProductName = "PUBG", UnitPrice = 80 };

            ISalesService salesService = new SalesManager();
            salesService.CampaignSale(product1, gamer, campaign);
        }
    }
}
