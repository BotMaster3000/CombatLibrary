using Microsoft.VisualStudio.TestTools.UnitTesting;
using CombatLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.EntityObjects;

namespace CombatLibrary.Entities.Tests
{
    [TestClass]
    public class PlayerTests
    {
        private const string name = "Bob";
        private const string title = "Master";
        private const int maxHealth = 100;
        private const int currentHealth = 100;
        private const string speciesName = "Human";
        private const int level = 13;
        private const int xp = 123;
        private readonly Map map = new Map(10, 10);

        private readonly Creature creature = Creatures.Human();

        [TestMethod]
        public void PlayerConstructorTest()
        {
            Player player = new Player(name, title, maxHealth, currentHealth, speciesName, level, xp);

            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(title, player.Title);
            Assert.AreEqual(maxHealth, player.MaxHealth);
            Assert.AreEqual(currentHealth, player.CurrentHealth);
            Assert.AreEqual(speciesName, player.SpeciesName);
            Assert.AreEqual(level, player.Level);
            Assert.AreEqual(xp, player.XP);
        }

        [TestMethod]
        public void PlayerConstructorTest2()
        {
            Player player = new Player(name, title, creature);

            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(title, player.Title);
            Assert.AreEqual(creature.MaxHealth, player.MaxHealth);
            Assert.AreEqual(creature.CurrentHealth, player.CurrentHealth);
            Assert.AreEqual(creature.SpeciesName, player.SpeciesName);
            Assert.AreEqual(creature.Level, player.Level);
            Assert.AreEqual(creature.XP, player.XP);
        }

        [TestMethod]
        public void MoveTest()
        {
            const int moveToXPos = 5;
            const int moveToYPos = 5;
            Player player = new Player(name, title, creature)
            {
                Map = map,
                CurrentLocation = map.Tiles[0],
            };
            player.Move(moveToXPos, moveToYPos);

            Assert.IsTrue(player.CurrentLocation.XPos == moveToXPos);
            Assert.IsTrue(player.CurrentLocation.YPos == moveToYPos);
        }

        [TestMethod]
        public void RecruitTest()
        {
            map.Tiles[0].Location = Locations.Town();
            Player player = new Player(name, title, creature)
            {
                CurrentLocation = map.Tiles[0],
            };

            player.Recruit();

            Assert.IsTrue(player.Companions.Count > 0);
        }

        [TestMethod]
        public void SleepTest()
        {
            Player player = new Player(name, title, creature);
            player.CurrentHealth = player.MaxHealth / 2;
            player.Sleep();

            Assert.IsTrue(player.CurrentHealth == player.MaxHealth);
        }
    }
}