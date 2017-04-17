using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Guilds.Enums;
using AQ.GameSaver.Score_Card;

namespace AQ.GameSaver.Guilds
{
    public class Guild
    {
        private List<HeroCard> _heroes;

        public Guild(Team team, Guid gameId, string playerName)
        {
            _heroes = new List<HeroCard>();
            DeathCurses = new List<DeathCurseCard>();
            Id = Guid.NewGuid();
            Team = team;
            PlayerName = playerName;
            GameId = gameId;
        }

        public Guid Id { get; }
        public string PlayerName { get; }
        public Team Team { get; }
        public IEnumerable<HeroCard> Heroes { get { return _heroes; } }
        public List<DeathCurseCard> DeathCurses { get; }
        public bool SavedMoney { get; set; }
        public Guid GameId { get; }


        public void AddHero(HeroCard hero)
        {
            if (_heroes.Count < 3)
            {
                hero.HasTeam = true;
                _heroes.Add(hero);
            }
        }

        public override string ToString()
        {
            return Team.ToString();
        }
    }
}
