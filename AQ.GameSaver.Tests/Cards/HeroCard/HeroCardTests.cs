using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AQ.GameSaver.Cards;
using AQ.GameSaver.Cards.Enums.AttackCardEnums;
using AQ.GameSaver.Cards.Enums.BoostCardEnums;
using AQ.GameSaver.Cards.Enums.PermanentCardEnums;

namespace AQ.GameSaver.Tests.Cards.HeroCard
{
    [TestClass]
    public class HeroCardTests
    {
        [TestMethod]
        public void DeleteCardMethodDeletesCorrectCard_Test()
        {
            var heroCard = new GameSaver.Cards.HeroCard("Spike", 3, 2);

            var attackCard = new AttackCard("Smashface", 1, 3, AttackType.Melee, WeaponType.Hammer);
            var boostCard = new BoostCard("Crushing Gauntlet", 3, BoostCardType.Gear);
            var permanentCard = new PermanentCard("Heart of the Unicorn", 0, PermanentCardType.Bling);

            heroCard.AddAttackCard(attackCard);
            heroCard.AddBoostCard(boostCard);
            heroCard.AddPermanentCard(permanentCard);

            heroCard.DeleteCard(boostCard);



            Assert.IsTrue(!heroCard.BoostCards.Any());
        }
    }
}
