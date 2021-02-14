using GameStore.Adaptor;
using GameStore.Concrete;
using GameStore.Entity;
using System;
using System.Collections.Generic;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //mernis sistemi bütün bilgiler dogru oldugu zaman calışır
            Gamer gamer = new Gamer();
            gamer.BirthYear = 2000;
            gamer.FirstName = "mustafa";
            gamer.LastName = "ÖZTÜRK";
            gamer.NationalityId = 11111111111;
            gamer.Nick = "mustafa.zturkk";
            gamer.Balance = 200;

            GamerManeger gamerManeger = new GamerManeger(new MernisServiceAdapter());
            gamerManeger.Add(gamer);

            Game pupge = new Game();
            pupge.GameName = "pupge";
            pupge.UnitPrice = 50;
            pupge.GameSize = 5;


            Game CsGO = new Game();
            CsGO.GameName = "CsGO";
            CsGO.UnitPrice = 80;
            CsGO.GameSize = 9;



            ProductManeger productManeger = new ProductManeger(new Gamer(),new Game());
            productManeger.sell(gamer, pupge);
            productManeger.sell(gamer, CsGO);



            foreach (var item in gamer.Games)
            {
                Console.WriteLine(item.GameName);
            }

            Campaign campaignA = new Campaign { CampaignId = 1, CampaignName = "Yeni yıl kampanyası", DiscountRate = 20 };
            Campaign campaignB = new Campaign { CampaignId = 2, CampaignName = "Yıl sonu kampanyası", DiscountRate = 30 };

            CampaignManeger campaignManeger = new CampaignManeger(new Campaign());

            campaignManeger.Add(campaignA);
            campaignManeger.Add(campaignB);

            campaignManeger.ShowCampaign();

            List<Campaign> campaigns = new List<Campaign> { campaignA, campaignB };

            productManeger.sell(gamer, pupge,campaigns);
            productManeger.sell(gamer, CsGO,campaigns);




        }
    }
}
