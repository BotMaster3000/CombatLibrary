﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IItemInterface
    {
        string Name { get; set; }
        string Description { get; set; }

        double Weight { get; set; }
        double Volume { get; set; }
    }
}
