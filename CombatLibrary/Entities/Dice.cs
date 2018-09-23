using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Dice : IDiceInterface
    {
        public int Amount { get; set; }
        public int Sides { get; set; }
        public Random Rand { get; set; }

        public int RollDice()
        {
            return Rand.Next(1, Amount * Sides + 1);
        }

        public Dice(int amount, int sides, Random rand)
        {
            Amount = amount;
            Sides = sides;
            Rand = rand;
        }
    }
}
