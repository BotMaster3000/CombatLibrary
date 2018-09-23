using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;
using CombatLibrary.Interfaces;

namespace CombatLibrary.EntityObjects
{
    public static class Creatures
    {
        public static Creature Goblin()
        {
            return new Creature("Goblin", 15, 15)
            {
                Attacks = new IAttackInterface[]
                {
                    Attacks.Bite(),
                    Attacks.Kick(),
                    Attacks.Punch(),
                },
            };
        }

        public static Creature Snake()
        {
            return new Creature("Snake", 5, 5)
            {
                Attacks = new IAttackInterface[]
                {
                    Attacks.Bite(),
                }
            };
        }

        public static Creature Human()
        {
            return new Creature("Human", 80, 80)
            {
                Attacks = new IAttackInterface[]
                {
                    Attacks.Bite(),
                    Attacks.Kick(),
                    Attacks.Punch(),
                }
            };
        }
    }
}
