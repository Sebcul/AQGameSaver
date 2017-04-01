using System;
using AQ.GameSaver.Cards.Enums.PermanentCardEnums;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class PermanentCard : ICard
    {

        public PermanentCard(string name, int cost, PermanentCardType cardType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            CardType = cardType;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Cost { get; }
        public PermanentCardType CardType { get; }
    }
}
