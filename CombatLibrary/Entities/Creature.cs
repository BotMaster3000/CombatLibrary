using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Creature : ICreatureInterface
    {
        public string SpeciesName { get; set; }

        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public IAttackInterface[] Attacks { get; set; }

        public Creature(string speciesName, int maxHealth, int currentHealth, int level = 1, int xp = 0)
        {
            SpeciesName = speciesName;
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
            Level = level;
            XP = xp;
        }
    }
}
