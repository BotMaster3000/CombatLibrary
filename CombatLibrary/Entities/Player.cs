using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Player : Character, IPlayerInterface
    {
        public List<ICharacterInterface> Companions { get; set; } = new List<ICharacterInterface>();
        public string Name { get; set; }
        public string Title { get; set; }
        public List<IActionInterface> PossibleActions { get; set; } = new List<IActionInterface>();
        public ITileInterface CurrentLocation { get; set; }

        public Player(string name, string title, int maxHealth, int currentHealth, string speciesName, int level = 1, int xp = 0) : base(speciesName, maxHealth, currentHealth, level, xp)
        {
            Name = name;
            Title = title;
        }
    }
}
