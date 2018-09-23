using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IActionInterface
    {
        string Name { get; set; }
        string Description { get; set; }

        void Execute();
    }
}
