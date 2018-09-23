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
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerConstructorTest()
        {
            Player player = new Player("Bob", "" , 100, 100, "Human", 1, 0);
        }
    }
}