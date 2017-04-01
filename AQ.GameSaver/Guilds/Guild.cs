using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Guilds.Enums;

namespace AQ.GameSaver.Guilds
{
    public class Guild
    {
        private List<HeroCard> _heroes;

        public Guild(Team team)
        {
            _heroes = new List<HeroCard>();
            DeathCurses = new List<DeathCurseCard>();
            Id = Guid.NewGuid();
            Team = team;
        }

        public Guid Id { get; }
        public Team Team { get; }
        public IEnumerable<HeroCard> Heroes { get { return _heroes; } }
        public List<DeathCurseCard> DeathCurses { get; }


        public void AddHero(HeroCard hero)
        {
            if (_heroes.Count < 3)
            {
                _heroes.Add(hero);
            }
        }
    }
}
