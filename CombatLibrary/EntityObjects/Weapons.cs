using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;
using CombatLibrary.EntityObjects;

namespace CombatLibrary.EntityObjects
{
    public static class Weapons
    {
        public static Weapon Sword()
        {
            return new Weapon("Sword", Dices.Dice1D4(), "Its a sword", 3, 5);
        }
    }
}
