using System;
using AQ.GameSaver.Cards.Enums.AttackCardEnums;
using AQ.GameSaver.Cards.Interfaces;

namespace AQ.GameSaver.Cards
{
    public class AttackCard : ICard
    {
        public AttackCard(string name, int cost, AttackType attackType, WeaponType weaponType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            AttackType = attackType;
            WeaponType = weaponType;

        }

        public Guid Id { get; }
        public string Name { get; }
        public int Cost { get; }
        public AttackType AttackType { get; }
        public WeaponType WeaponType { get; }
    }
}
