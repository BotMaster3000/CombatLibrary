using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface ICreatureInterface
    {
        string SpeciesName { get; set; }

        int MaxHealth { get; set; }
        int CurrentHealth { get; set; }
        int Level { get; set; }
        int XP { get; set; }

        IAttackInterface[] Attacks { get; set; }
    }
}
