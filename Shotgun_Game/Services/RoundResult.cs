using Shotgun_Game.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Services
{
    public enum RoundWinner { None, Human, Computer }

    public class RoundResult
    {
        public required Move HumanMove { get; init; }
        public required Move ComputerMove { get; init; }
        public int HumanBulletChange { get; init; }
        public int ComputerBulletChange { get; init; }
        public bool GameEnded { get; init; }
        public RoundWinner RoundWinner { get; init; }   
        public string Message { get; init; } = string.Empty;
    }
}
