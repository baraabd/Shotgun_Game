using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Domain
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name) { }       

        public override Move ChooseMove(int enemyBullets) => Move.Block;                                       
    }
}
