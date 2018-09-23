using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Characters
    {
        public static Character Goblin_Swordsman_LeatherArmor()
        {
            return new Character(Creatures.Goblin())
            {
                Armor = Armors.LeatherArmor(),
                Weapon = Weapons.Sword(),
            };
        }
    }
}
