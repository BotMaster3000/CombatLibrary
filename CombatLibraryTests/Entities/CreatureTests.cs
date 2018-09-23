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
    public class CreatureTests
    {
        [TestMethod]
        public void CreatureTest()
        {
            const string name = "Kobold";
            const int maxHealth = 15;
            const int currentHealth = 14;
            const int lvl = 2;
            const int xp = 13;

            Creature creature = new Creature(name, maxHealth, currentHealth, lvl, xp);

            Assert.AreEqual(name, creature.SpeciesName);
            Assert.AreEqual(maxHealth, creature.MaxHealth);
            Assert.AreEqual(currentHealth, creature.CurrentHealth);
            Assert.AreEqual(lvl, creature.Level);
            Assert.AreEqual(xp, creature.XP);
        }
    }
}