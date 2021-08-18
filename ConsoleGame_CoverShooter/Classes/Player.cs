using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Player
    {
        public int AC { get; set; } = 10;
        public int HP { get; set; } = 50;

        public void Shoot(IEnemy enemy)
        {
            Random rand = new Random();
            Thread.Sleep(10);
            int shot = rand.Next(1, 21) + 3;
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot}");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }

        public void TakeCover()
        {
            AC = 17;
            Console.WriteLine("you take cover!");
        }
    }
}
