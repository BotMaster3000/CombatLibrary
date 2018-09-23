using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IDiceInterface
    {
        int Amount { get; set; }
        int Sides { get; set; }
        Random Rand { get; set; }

        int RollDice();
    }
}
