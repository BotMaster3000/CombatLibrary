using Microsoft.VisualStudio.TestTools.UnitTesting;
using CombatLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Entities.Tests
{
    [TestClass]
    public class DiceTests
    {
        private const int amount = 2;
        private const int sides = 4;
        private static readonly Random rand = new Random();
        private readonly int maxDiceAmount = amount * sides;

        [TestMethod]
        public void DiceConstructorTest()
        {
            Dice dice = new Dice(amount, sides, rand);

            Assert.AreEqual(amount, dice.Amount);
            Assert.AreEqual(sides, dice.Sides);
        }

        [TestMethod]
        public void RollDiceTest()
        {
            Dice dice = new Dice(amount, sides, rand);
            for (int i = 0; i < 50; ++i)
            {
                int result = dice.RollDice();
                Assert.IsTrue(result >= 1 && result <= maxDiceAmount);
            }
        }

        [TestMethod]
        public void RollDiceTestMaxAmountPossible()
        {
            Dice dice = new Dice(amount, sides, rand);
            bool isPossible = false;
            for (int i = 0; i < 50; ++i)
            {
                int result = dice.RollDice();
                if (result == maxDiceAmount)
                {
                    isPossible = true;
                    break;
                }
            }
            Assert.IsTrue(isPossible);
        }
    }
}