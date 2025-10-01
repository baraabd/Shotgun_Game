using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Domain
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }         

        public override Move ChooseMove(int enemyBullets) => Move.Load;                                          
    }
}
