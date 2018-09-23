using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface ITileInterface
    {
        int XPos { get; set; }
        int YPos { get; set; }
        ILocationInterface Location { get; set; }
    }
}
