using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IArmorInterface : IItemInterface
    {
        int ArmorValue { get; set; }
        double Coverage { get; set; }
    }
}
