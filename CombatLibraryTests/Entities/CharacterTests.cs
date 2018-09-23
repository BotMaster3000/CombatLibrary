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
    public class CharacterTests
    {
        private const string speciesName = "Blub";
        private const int maxHealth = 42;
        private const int currentHealth = 32;
        private const int lvl = 2;
        private const int xp = 124;

        [TestMethod]
        public void CharacterConstructorTest()
        {
            Character character = new Character(speciesName, maxHealth, currentHealth, lvl, xp);

            Assert.AreEqual(speciesName, character.SpeciesName);
            Assert.AreEqual(maxHealth, character.MaxHealth);
            Assert.AreEqual(currentHealth, character.CurrentHealth);
            Assert.AreEqual(lvl, character.Level);
            Assert.AreEqual(xp, character.XP);
        }

        [TestMethod]
        public void CharacterConstructorTest2()
        {
            Creature creature = new Creature(speciesName, maxHealth, currentHealth, lvl, xp);
            Character character = new Character(creature);

            Assert.AreEqual(speciesName, character.SpeciesName);
            Assert.AreEqual(maxHealth, character.MaxHealth);
            Assert.AreEqual(currentHealth, character.CurrentHealth);
            Assert.AreEqual(lvl, character.Level);
            Assert.AreEqual(xp, character.XP);
        }
    }
}