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
    public class ArmorTests
    {
        [TestMethod]
        public void ArmorConstructorTest()
        {
            const string name = "Leather Armor";
            const string description = "A armor made of Leather";
            const int armorValue = 3;
            const double coverage = 75;
            Armor armor = new Armor(name, description, armorValue, coverage);

            Assert.AreEqual(name, armor.Name);
            Assert.AreEqual(description, armor.Description);
            Assert.AreEqual(armorValue, armor.ArmorValue);
            Assert.AreEqual(coverage, armor.Coverage);
        }
    }
}