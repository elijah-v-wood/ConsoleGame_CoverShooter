using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class BlueEnemy : IEnemy, IShooter
    {
        public int AC { get; set; } = 10;
        public int HP { get; set; } = 15;
        public void TakeCover()
        {
            AC += 7;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot()
        {
            AC = 10;
            Random rand = new Random();
        }
        public void Action1()
        {
            Shoot();
        }

        public void Action2()
        {
            TakeCover();
        }

        public void Action3()
        {
            TakeCover();
        }


    }
}
