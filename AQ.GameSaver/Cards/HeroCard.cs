using System;
using System.Collections.Generic;
using System.Linq;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class HeroCard
    {
        private List<AttackCard> _attackCards;
        private List<PermanentCard> _permanentCards;
        private List<BoostCard> _boostCards;

        public HeroCard(string name, int life, int defense)
        {
            _attackCards = new List<AttackCard>();
            _permanentCards = new List<PermanentCard>();
            _boostCards = new List<BoostCard>();

            Id = Guid.NewGuid();
            Name = name;
            Life = life;
            Defense = defense;
            HasTeam = false;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Life { get; }
        public int Defense { get; }
        public IEnumerable<AttackCard> AttackCards { get { return _attackCards; } }
        public IEnumerable<PermanentCard> PermanentCards { get { return _permanentCards; } }
        public IEnumerable<BoostCard> BoostCards { get { return _boostCards; } }
        public bool HasTeam { get; set; }


        public void AddAttackCard(AttackCard card)
        {
            if (_attackCards.Count + _permanentCards.Count + _boostCards.Count < 4)
            {
                _attackCards.Add(card);
            }
        }

        public void AddPermanentCard(PermanentCard card)
        {
            if (_attackCards.Count + _permanentCards.Count + _boostCards.Count < 4)
            {
                _permanentCards.Add(card);
            }
        }

        public void AddBoostCard(BoostCard card)
        {
            if (_attackCards.Count + _permanentCards.Count + _boostCards.Count < 4)
            {
                _boostCards.Add(card);
            }
        }

        public void DeleteCard(ICard card)
        {
            var attackCardToDelte = _attackCards.FirstOrDefault(x => x.Id == card.Id);
            var permanentCardToDelte = _permanentCards.FirstOrDefault(x => x.Id == card.Id);
            var boostCardToDelete = _boostCards.FirstOrDefault(x => x.Id == card.Id);

            if (attackCardToDelte != null && attackCardToDelte.Id == card.Id)
            {
                _attackCards.Remove(attackCardToDelte);
            }
            else if (permanentCardToDelte != null && permanentCardToDelte.Id == card.Id)
            {
                _permanentCards.Remove(permanentCardToDelte);
            }
            else if (boostCardToDelete != null && boostCardToDelete.Id == card.Id)
            {
                _boostCards.Remove(boostCardToDelete);
            }
        }

    }
}
