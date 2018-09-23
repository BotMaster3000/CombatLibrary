using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary.Entities;
using CombatLibrary.Enums;

namespace CombatLibrary.EntityObjects
{
    public static class Locations
    {
        public static Location Grassland()
        {
            return new Location("Grassland", "You see wide fields of grass");
        }

        public static Location Town()
        {
            return new Location("Town", "A town")
            {
                PossibleActions = new LocationActions[]
                {
                    LocationActions.Shop,
                    LocationActions.Recruit,
                    LocationActions.Camp
                }
            };
        }
    }
}
