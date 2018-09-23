using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Enums;

namespace CombatLibrary.Interfaces
{
    public interface ILocationInterface
    {
        string Name { get; set; }
        string Description { get; set; }

        LocationActions[] PossibleActions { get; set; }
    }
}
