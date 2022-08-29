using GameReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Abstract
{
    interface IGameSalesService
    {
        void Sales(Member member, Game game, Campaign campaign);
        void Sales(Member member, Game game);
    }
}
