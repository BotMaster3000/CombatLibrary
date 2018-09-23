using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IMapInterface
    {
        int Width { get; set; }
        int Height { get; set; }

        ITileInterface[] Tiles { get; set; }
    }
}
