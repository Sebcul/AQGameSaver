using System;
using AQ.GameSaver.Cards.Enums.BoostCardEnums;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class BoostCard : ICard
    {
        public BoostCard(string name, int cost, BoostCardType cardType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            CardType = cardType;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Cost { get; }
        public BoostCardType CardType { get; }
    }
}
