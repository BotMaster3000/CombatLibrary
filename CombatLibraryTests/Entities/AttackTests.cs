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
    public class AttackTests
    {
        [TestMethod]
        public void AttackConstructorTest()
        {
            const string name = "Bite";
            const string description = "Try to ram your teeth into the enemy";
            Dice dice = new Dice(1, 2, new Random());
            Attack attack = new Attack(name, dice, description);

            Assert.AreEqual(name, attack.Name);
            Assert.AreEqual(description, attack.Description);
            Assert.AreEqual(dice, attack.DamageDice);
        }
    }
}