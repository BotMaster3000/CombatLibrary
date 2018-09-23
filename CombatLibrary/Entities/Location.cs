using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;
using CombatLibrary.Enums;

namespace CombatLibrary.Entities
{
    public class Location : ILocationInterface
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public LocationActions[] PossibleActions { get; set; }

        public Location(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
