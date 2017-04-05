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
            LoadDefaultMaps();
        }

        public Guid Id { get; }
        public string Name { get; }
        public IEnumerable<CampaignMap> Maps { get; }
        public Guild MostWinsMedal { get; set; }
        public Guild LeastDeathsMedal { get; set; }
        public Guild MostCoinsMedal { get; set; }
        public Guild MostRewardWonMedal { get; set; }
        public Guild MostTitleWonMedal { get; set; }

        private void LoadDefaultMaps()
        {
            _maps.Add(new CampaignMap("District of Hammers", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("Brightsun Arena", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("The Moon Game", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("The Rookery", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("The Manor", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("The Orcs' Hive", CircleType.OuterCircle));
            _maps.Add(new CampaignMap("Alchemist's District", CircleType.InnerCircle));
            _maps.Add(new CampaignMap("The University Plaza", CircleType.InnerCircle));
            _maps.Add(new CampaignMap("Red Dawn Square", CircleType.InnerCircle));
            _maps.Add(new CampaignMap("Evershadow District", CircleType.InnerCircle));
            _maps.Add(new CampaignMap("The Temple of Dawning Twilight", CircleType.FinalShowdown));
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
