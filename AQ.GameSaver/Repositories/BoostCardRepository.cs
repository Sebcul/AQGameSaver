using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Cards.Enums.BoostCardEnums;
using AQ.GameSaver.Repository.Interfaces;

namespace AQ.GameSaver.Repositories
{
    public sealed class BoostCardRepository : IRepository<BoostCard>
    {
        public static readonly BoostCardRepository _instance = new BoostCardRepository();
        private List<BoostCard> _boostCards;


        private BoostCardRepository()
        {
            _boostCards = new List<BoostCard>();
            LoadData();
        }

        public void Add(BoostCard boostCard)
        {
            _boostCards.Add(boostCard);
        }

        public void Delete(Guid id)
        {
            var boostCardToRemove = _boostCards.Find(x => x.Id == id);
            _boostCards.Remove(boostCardToRemove);

        }

        public IEnumerable<BoostCard> GetAll()
        {
            return _boostCards;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            _boostCards.Add(new BoostCard("Moon Ring", 4, BoostCardType.Bling));
        }
    }
}
