using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;

namespace CombatLibrary.Entities
{
    public class Tile : ITileInterface
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public ILocationInterface Location { get; set; }

        public Tile(int xPos, int yPos, ILocationInterface location)
        {
            XPos = xPos;
            YPos = yPos;
            Location = location;
        }
    }
}
