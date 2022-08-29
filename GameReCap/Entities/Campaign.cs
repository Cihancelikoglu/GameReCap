using GameReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Sales { get; set; }
    }
}
