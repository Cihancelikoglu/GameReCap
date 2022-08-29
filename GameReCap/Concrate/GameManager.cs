using GameReCap.Abstract;
using GameReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Concrate
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void GameAdd(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + " " + "Oyunu" + " " + "Eklendi...");
        }
    }
}
