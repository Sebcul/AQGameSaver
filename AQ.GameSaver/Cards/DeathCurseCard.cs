using System;

namespace AQ.GameSaver.Cards
{
    public class DeathCurseCard
    {
        public DeathCurseCard(string name, int severity, bool minusLifeEffect, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Severity = severity;
            MinusLifeEffect = minusLifeEffect;
            Description = description;
        }

        public Guid Id { get; }
        public string Name { get; }
        public int Severity { get; }
        public bool MinusLifeEffect { get; }
        public string Description { get; }
    }
}
