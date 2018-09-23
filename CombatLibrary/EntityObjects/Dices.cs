using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Dices
    {
        private static readonly Random rand = new Random();

        public static Dice Dice1D4()
        {
            return new Dice(1, 4, rand);
        }

        public static Dice Dice1D2()
        {
            return new Dice(1, 2, rand);
        }
    }
}
