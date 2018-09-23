using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatLibrary.Interfaces
{
    public interface IPlayerActionsInterface
    {
        void Move(int xPos, int yPos);
        void Recruit();
        void Sleep();
    }
}
