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
    }
}
