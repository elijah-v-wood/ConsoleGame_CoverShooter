using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Player : IShooter
    {
        public int AC { get; set; } = 10;
        public int HP { get; set; } = 50;

        public void Shoot()
        {
            
        }

        public void TakeCover()
        {
            
        }
    }
}
