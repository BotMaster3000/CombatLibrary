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
    public class LocationTests
    {
        [TestMethod]
        public void LocationConstructorTest()
        {
            const string name = "BloodHell";
            const string description = "Literally hell";
            Location location = new Location(name, description);
        }
    }
}