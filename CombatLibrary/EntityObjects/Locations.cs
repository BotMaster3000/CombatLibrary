using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;

namespace CombatLibrary.EntityObjects
{
    public static class Locations
    {
        public static Location Grassland()
        {
            return new Location("Grassland", "You see wide fields of grass");
        }
    }
}
