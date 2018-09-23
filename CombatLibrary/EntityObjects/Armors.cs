using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Armors
    {
        public static Armor LeatherArmor()
        {
            return new Armor("Leather Armor", "A leather Armor", 3, 75, 15, 20);
        }
    }
}
