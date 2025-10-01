using Shotgun_Game.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Services
{
    public static class Rules
    {
        public static RoundResult Resolve(Move human, Move computer)
        {
            RoundResult result = new RoundResult
            {
                HumanMove = human,
                ComputerMove = computer,
                HumanBulletChange = 0,
                ComputerBulletChange = 0,
                GameEnded = false,
                RoundWinner = RoundWinner.None,
                Message = "No winner, Lets play again!"
            };
            return result;
        }
    }
}
