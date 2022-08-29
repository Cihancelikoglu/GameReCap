using GameReCap.Abstract;
using GameReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Concrate
{
    class GameSalesManager : IGameSalesService
    {
        public void Sales(Member member, Game game, Campaign campaign)
        {
            double campaignPrice = game.UnitPrice - (game.UnitPrice * campaign.Sales / 100);

            Console.WriteLine(member.FirstName + " " + game.GameName + " " + "Oyununu" + " " + campaign.CampaignName + " " + "Koduyla" + " " + campaignPrice + "TL'ye" + " Satın Aldı.");
        }

        public void Sales(Member member, Game game)
        {
            Console.WriteLine(member.FirstName + " " + game.GameName + " " + "Oyununu" + " " + game.UnitPrice + "TL'ye" + " Satın Aldı.");
        }
    }
}
