using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Character : Creature, ICharacterInterface
    {
        public IArmorInterface Armor { get; set; }
        public IWeaponInterface Weapon { get; set; }
        public List<IItemInterface> Items { get; set; }

        public Character(string name, int maxHealth, int currentHealth, int level = 1, int xp = 0) : base(name, maxHealth, currentHealth, level, xp)
        {

        }
    }
}
