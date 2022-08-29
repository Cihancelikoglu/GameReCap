using GameReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Entities
{
    public class Game: IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int UnitPrice { get; set; }
    }
}
