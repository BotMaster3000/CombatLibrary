using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Attacks
    {
        public static Attack Bite()
        {
            return new Attack("Bite", Dices.Dice1D2(), "Ram your teeth into the enemy");
        }

        public static Attack Punch()
        {
            return new Attack("Punch", Dices.Dice1D2(), "Punch the enemy");
        }

        public static Attack Kick()
        {
            return new Attack("Kick", Dices.Dice1D2(), "Kick the enemy");
        }
    }
}
