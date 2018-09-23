using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.EntityObjects;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Player : Character, IPlayerInterface, IPlayerActionsInterface
    {
        public List<ICharacterInterface> Companions { get; set; } = new List<ICharacterInterface>();
        public string Name { get; set; }
        public string Title { get; set; }
        public List<IActionInterface> PossibleActions { get; set; } = new List<IActionInterface>();
        public ITileInterface CurrentLocation { get; set; }
        public IMapInterface Map { get; set; }

        public Player(string name, string title, int maxHealth, int currentHealth, string speciesName, int level = 1, int xp = 0) : base(speciesName, maxHealth, currentHealth, level, xp)
        {
            Name = name;
            Title = title;
        }

        public Player(string name, string title, Creature creature) : base(creature)
        {
            Name = name;
            Title = title;
        }

        public void Move(int xPos, int yPos)
        {
            while(CurrentLocation.XPos != xPos && CurrentLocation.YPos != yPos)
            {
                int nextXPos = CurrentLocation.XPos > xPos ? CurrentLocation.XPos - 1 : CurrentLocation.XPos + 1;
                int nextYPos = CurrentLocation.YPos > yPos ? CurrentLocation.YPos - 1 : CurrentLocation.YPos + 1;

                foreach(Tile tile in Map.Tiles)
                {
                    if(tile.XPos == nextXPos && tile.YPos == nextYPos)
                    {
                        CurrentLocation = tile;
                        break;
                    }
                }
            }
        }

        public void Recruit()
        {
            Companions.Add(Characters.Goblin_Swordsman_LeatherArmor());
        }

        public void Sleep()
        {
            CurrentHealth = MaxHealth;
        }
    }
}
