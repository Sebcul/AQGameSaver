using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Guilds;

namespace AQ.GameSaver.Score_Card
{
    public class ScoreCard
    {
        public ScoreCard(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
        public CampaignMap Map { get; set; }
        public Guild MedalWinner { get; set; }
    }
}
