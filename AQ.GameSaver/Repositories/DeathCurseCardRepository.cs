using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class DeathCurseCardRepository : IRepository<DeathCurseCard>
    {
        public static readonly DeathCurseCardRepository _instance = new DeathCurseCardRepository();
        private List<DeathCurseCard> _deathCurseCards;


        private DeathCurseCardRepository()
        {
            _deathCurseCards = new List<DeathCurseCard>();
            LoadData();
        }

        public void Add(DeathCurseCard deathCurseCard)
        {
            _deathCurseCards.Add(deathCurseCard);
        }

        public void Delete(Guid id)
        {
            var deathCurseCardToRemove = _deathCurseCards.Find(x => x.Id == id);
            _deathCurseCards.Remove(deathCurseCardToRemove);

        }

        public IEnumerable<DeathCurseCard> GetAll()
        {
            return _deathCurseCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            _deathCurseCards.Add(new DeathCurseCard("No Curse", 0, false, false, "Nothing happens, discard this card."));
            _deathCurseCards.Add(new DeathCurseCard("Accident Prone", 6, false, false, "This hero suffers 1 Wound if his attack deals no Wounds."));
        }
    }
}
