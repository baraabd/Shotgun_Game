using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun_Game.Domain
{
    public abstract class Player             
    {
        public string Name { get; }           
        public int Bullets { get; protected set; } 

        protected Player(string name)        
        {
            Name = name;                      
            Bullets = 0;                     
        }

        public abstract Move ChooseMove(int enemyBullets);

        public bool CanShoot => Bullets > 0;    
        public bool CanShotgun => Bullets >= 3;   
    }
}
