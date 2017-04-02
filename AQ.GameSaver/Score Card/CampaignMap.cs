using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Guilds;
using AQ.GameSaver.Guilds.Enums;

namespace AQ.GameSaver.Score_Card
{
    public class CampaignMap
    {
        public CampaignMap(string mapName, CircleType circle)
        {
            Map = mapName;
            Circle = circle;
        }

        public string Map { get; }
        public CircleType Circle { get; }
        public Guild Winner { get; set; }
        public Guild LeastDeaths { get; set; }
        public Guild MostCoins { get; set; }
        public Guild WonReward { get; set; }
        public Guild WonTitle { get; set; }

    }
}
