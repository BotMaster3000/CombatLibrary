using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Armor : Item, IArmorInterface
    {
        public int ArmorValue { get; set; }
        public double Coverage { get; set; }

        public Armor(string name, string description, int armorValue, double coverage, double weight = 0, double volume = 0) : base(name, description, weight, volume)
        {
            ArmorValue = armorValue;
            Coverage = coverage;
        }
    }
}
