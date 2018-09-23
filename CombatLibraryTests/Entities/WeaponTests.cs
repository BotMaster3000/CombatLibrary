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
    public class WeaponTests
    {
        [TestMethod]
        public void WeaponConstructorTest()
        {
            Random rand = new Random();
            Dice dice = new Dice(1, 2, rand);
            const string name = "Swardid";
            const string description = "A true Swardid";
            Weapon weapon = new Weapon(name, dice, description);

            Assert.AreEqual(name, weapon.Name);
            Assert.AreEqual(description, weapon.Description);
        }
    }
}