using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IPlayerInterface : ICharacterInterface
    {
        List<ICharacterInterface> Companions { get; set; }
        string Name { get; set; }
        string Title { get; set; }

        IMapInterface Map { get; set; }
        ITileInterface CurrentLocation { get; set; }
        List<IActionInterface> PossibleActions { get; set; }
    }
}
