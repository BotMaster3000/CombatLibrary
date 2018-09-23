using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Creatures
    {
        public static Creature Goblin()
        {
            return new Creature("Goblin", 15, 15);
        }

        public static Creature Snake()
        {
            return new Creature("Snake", 5, 5);
        }
    }
}
