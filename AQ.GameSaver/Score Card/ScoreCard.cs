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
        private List<CampaignMap> _maps;

        public ScoreCard(string name)
        {
            _maps = new List<CampaignMap>();
            Id = Guid.NewGuid();
            Name = name;

        }

        public Guid Id { get; }
        public string Name { get; }
        public IEnumerable<CampaignMap> Maps { get; set; }
        public MedalWinner MedalWinner { get; set; }

        private void LoadDefaultMaps()
        {
            _maps.Add(new CampaignMap("District of Hammers"));
            _maps.Add(new CampaignMap("Brightsun Arena"));
            _maps.Add(new CampaignMap("The Moon Game"));
            _maps.Add(new CampaignMap("The Rookery"));
            _maps.Add(new CampaignMap("The Manor"));
            _maps.Add(new CampaignMap("The Orcs' Hive"));
            _maps.Add(new CampaignMap("Alchemist's District"));
            _maps.Add(new CampaignMap("The University Plaza"));
            _maps.Add(new CampaignMap("Red Dawn Square"));
            _maps.Add(new CampaignMap("Evershadow District"));
            _maps.Add(new CampaignMap("The Temple of Dawning Twilight"));
        }
    }

}
