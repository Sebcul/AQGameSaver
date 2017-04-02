using System;
using AQ.GameSaver.Cards.Enums.AttackCardEnums;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class AttackCard : ICard
    {
        public AttackCard(string name, int cost, int level, AttackType attackType, WeaponType weaponType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Level = level;
            AttackType = attackType;
            WeaponType = weaponType;

        }

        public Guid Id { get; }
        public string Name { get; }
        public int Cost { get; }
        public int Level { get; }
        public AttackType AttackType { get; }
        public WeaponType WeaponType { get; }

    }
}
