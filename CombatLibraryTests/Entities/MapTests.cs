using Microsoft.VisualStudio.TestTools.UnitTesting;
using CombatLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities.Tests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void MapConstructorTest()
        {
            const int mapWidth = 10;
            const int mapHeight = 15;

            Map map = new Map(mapWidth, mapHeight);

            Assert.AreEqual(mapWidth, map.Width);
            Assert.AreEqual(mapHeight, map.Height);
            Assert.AreEqual(mapWidth * mapHeight, map.Tiles.Length);

            for (int i = 0; i < map.Tiles.Length; i++)
            {
                Assert.IsTrue(map.Tiles[i] != null);
                Assert.IsTrue(map.Tiles[i].XPos >= 0 && map.Tiles[i].XPos < mapWidth);
                Assert.IsTrue(map.Tiles[i].YPos >= 0 && map.Tiles[i].YPos < mapHeight);
            }
        }
    }
}