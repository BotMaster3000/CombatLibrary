using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Item : IItemInterface
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double Weight { get; set; }
        public double Volume { get; set; }

        public Item(string name, string description, double weight = 0, double volume = 0)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Volume = volume;
        }
    }
}
