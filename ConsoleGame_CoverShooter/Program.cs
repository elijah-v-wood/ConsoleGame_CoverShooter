using ConsoleGame_CoverShooter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            BlueEnemy blue = new BlueEnemy();

            blue.Action1(player);
        }
    }
}
