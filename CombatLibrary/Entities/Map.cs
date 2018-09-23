using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Interfaces;
using CombatLibrary.EntityObjects;

namespace CombatLibrary.Entities
{
    public class Map : IMapInterface
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ITileInterface[] Tiles { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            GenerateMap();
        }

        private void GenerateMap()
        {
            Tiles = new Tile[Width * Height];
            int tilePosition = 0;
            for(int yPos = 0; yPos < Height; ++yPos)
            {
                for(int xPos = 0; xPos < Width; ++xPos)
                {
                    Tiles[tilePosition] = new Tile(xPos, yPos, Locations.Grassland());
                    ++tilePosition;
                }
            }
        }
    }
}
