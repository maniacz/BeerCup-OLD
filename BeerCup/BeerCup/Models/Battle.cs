using System;
using System.Collections.Generic;
using System.Text;

namespace BeerCup.Models
{
    public class Battle
    {
        public string Style { get; }
        public List<Brewery> BattleCompetitors { get; }

        public Dictionary<byte, Brewery> beerCoding;

        public Battle()
        {
            Style = "Weizen";
            BattleCompetitors = new List<Brewery>
            {
                new Brewery("BroGar"),
                new Brewery("Hołda Chmielu"),
                new Brewery("Venom"),
                new Brewery("Bastion"),
                new Brewery("Citra")
            };
        }
    }
}
