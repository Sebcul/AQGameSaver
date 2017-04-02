using System;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class DeathCurseCard : ICard
    {
        public DeathCurseCard(string name, int severity, bool minusLifeEffect, bool occupiesCardSlot, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Severity = severity;
            MinusLifeEffect = minusLifeEffect;
            OccupiesCardSlot = occupiesCardSlot;
            Description = description;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Severity { get; }
        public bool MinusLifeEffect { get; }
        public bool OccupiesCardSlot { get; }
        public string Description { get; }
    }
}
