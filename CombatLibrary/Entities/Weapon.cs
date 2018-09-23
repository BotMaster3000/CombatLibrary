using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Weapon : Item, IWeaponInterface
    {
        public IDiceInterface DamageDice { get; set; }

        public Weapon(string name, Dice damageDice, string description, double weight = 0, double volume = 0)
                    : base(name, description, weight, volume)
        {
            DamageDice = damageDice;
        }
    }
}
