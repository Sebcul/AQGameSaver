using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Cards.Enums.PermanentCardEnums;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class PermanentCardRepository : IRepository<PermanentCard>
    {
        public static readonly PermanentCardRepository _instance = new PermanentCardRepository();
        private List<PermanentCard> _permanentCards;


        private PermanentCardRepository()
        {
            _permanentCards = new List<PermanentCard>();
            LoadData();
        }

        public void Add(PermanentCard permanentCard)
        {
            _permanentCards.Add(permanentCard);
        }

        public void Delete(Guid id)
        {
            var boostCardToRemove = _permanentCards.Find(x => x.Id == id);
            _permanentCards.Remove(boostCardToRemove);

        }

        public IEnumerable<PermanentCard> GetAll()
        {
            return _permanentCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            _permanentCards.Add(new PermanentCard("Das Boot", 0, PermanentCardType.Gear));
        }
    }
}
