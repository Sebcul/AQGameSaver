using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class HeroCardRepository : IRepository<HeroCard>
    {
        public static readonly HeroCardRepository _instance = new HeroCardRepository();
        private List<HeroCard> _heroCards;

        public HeroCardRepository()
        {
            _heroCards = new List<HeroCard>();
            LoadData();
        }

        public void Add(HeroCard hero)
        {
            _heroCards.Add(hero);
        }

        public void Delete(Guid id)
        {
            var heroCardToRemove = _heroCards.Find(x => x.Id == id);
            _heroCards.Remove(heroCardToRemove);
        }

        public IEnumerable<HeroCard> GetAll()
        {
            return _heroCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            _heroCards.Add(new HeroCard("Spike", 3, 2));
        }
    }
}
