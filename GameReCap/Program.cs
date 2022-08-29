using GameReCap.Abstract;
using GameReCap.Adapter;
using GameReCap.Concrate;
using GameReCap.Entities;
using System;
using System.Collections.Generic;

namespace GameReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Gamer Add-------------------------//
            Member member = new Member
            {
                BirthDate = new DateTime(1999, 05, 09),
                FirstName = "Cihan",
                LastName = "Çelikoğlu",
                NationalityId = "64300199406"
            };
            Member member2 = new Member
            {
                BirthDate = new DateTime(1970, 05, 09),
                FirstName = "Galip",
                LastName = "Çelikoğlu",
                NationalityId = "64459194192"
            };
            BaseMemberManager memberManager = new MemberManager(new MernisServiceAdapter());
            memberManager.Add(member);
            memberManager.Add(member2);

            Console.WriteLine("");
            //-------------------Game Add-------------------------//
            GameManager gameManager = new GameManager();

            Game game1 = new Game();
            game1.GameName = "Fifa 2022";
            game1.UnitPrice = 500;

            Game game2 = new Game();
            game2.GameName = "CS:GO";
            game2.UnitPrice = 100;

            gameManager.GameAdd(game1);
            gameManager.GameAdd(game2);

            Console.WriteLine("");
            //-------------------Game Sales-------------------------//
            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales(member, game1);

            Console.WriteLine("");
            //-------------------Campaign Game Sales-------------------------//
            CampaignManager campaignManager = new CampaignManager();

            Campaign campaign50 = new Campaign();
            campaign50.CampaignName = "50İNDİRİM";
            campaign50.Sales = 50;

            Campaign campaign30 = new Campaign();
            campaign30.CampaignName = "30İNDİRİM";
            campaign30.Sales = 30;

            campaignManager.Add(campaign30);
            campaignManager.Add(campaign50);

            gameSalesManager.Sales(member2, game1, campaign30);

        }
    }
}
