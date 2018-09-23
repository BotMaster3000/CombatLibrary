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
    public class TileTests
    {
        [TestMethod]
        public void TileConstructorTest()
        {
            const int xPos = 1;
            const int yPos = 3;
            Location location = new Location("Grassland", "Wide fields of grass");
            Tile tile = new Tile(xPos, yPos, location);

            Assert.AreEqual(xPos, tile.XPos);
            Assert.AreEqual(yPos, tile.YPos);
            Assert.AreEqual(location, tile.Location);
        }
    }
}