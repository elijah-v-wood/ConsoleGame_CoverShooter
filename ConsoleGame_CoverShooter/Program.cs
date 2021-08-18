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
            BlueEnemy blue = new BlueEnemy();
            Console.WriteLine(blue.AC);
            blue.TakeCover();
            Console.WriteLine(blue.AC);
            Console.ReadKey();

        }
    }
}
