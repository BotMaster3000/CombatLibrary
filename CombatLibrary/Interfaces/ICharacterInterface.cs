using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface ICharacterInterface : ICreatureInterface
    {
        IArmorInterface Armor { get; set; }
        IWeaponInterface Weapon { get; set; }
        List<IItemInterface> Items { get; set; }
    }
}
