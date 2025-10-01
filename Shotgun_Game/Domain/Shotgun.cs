using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Domain
{
    public enum Move
            {
        Load = 1,       // Load one bullet
        Block = 2,      // Block the next incoming shot
        Shoot = 3,      // Shoot the opponent
        Shotgun = 4     // Use shotgun (requires 3 bullets)
    }
}
