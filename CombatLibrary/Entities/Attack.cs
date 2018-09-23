using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Attack : IAttackInterface
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IDiceInterface DamageDice { get; set; }

        public Attack(string name, Dice damageDice, string description = "")
        {
            Name = name;
            DamageDice = damageDice;
            Description = description;
        }
    }
}
