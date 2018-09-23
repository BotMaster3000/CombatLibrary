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
        private const string speciesName = "Kobold";
        private const int maxHealth = 15;
        private const int currentHealth = 14;
        private const int lvl = 2;
        private const int xp = 13;

        [TestMethod]
        public void CreatureConstructorTest()
        {
            Creature creature = new Creature(speciesName, maxHealth, currentHealth, lvl, xp);

            Assert.AreEqual(speciesName, creature.SpeciesName);
            Assert.AreEqual(maxHealth, creature.MaxHealth);
            Assert.AreEqual(currentHealth, creature.CurrentHealth);
            Assert.AreEqual(lvl, creature.Level);
            Assert.AreEqual(xp, creature.XP);
        }

        [TestMethod]
        public void CreatureConstructorTest2()
        {
            Creature oldCreature = new Creature(speciesName, maxHealth, currentHealth, lvl, xp);
            Creature newCreature = new Creature(oldCreature);

            Assert.AreEqual(speciesName, newCreature.SpeciesName);
            Assert.AreEqual(maxHealth, newCreature.MaxHealth);
            Assert.AreEqual(currentHealth, newCreature.CurrentHealth);
            Assert.AreEqual(lvl, newCreature.Level);
            Assert.AreEqual(xp, newCreature.XP);
        }
    }
}