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
    public class ItemTests
    {
        [TestMethod]
        public void ItemConstructorTest()
        {
            string name = "Bla";
            string description = "Bli";
            double weight = 3;
            double volume = 12;
            Item item = new Item(name, description, weight, volume);

            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(description, item.Description);
            Assert.AreEqual(weight, item.Weight);
            Assert.AreEqual(volume, item.Volume);
        }
    }
}