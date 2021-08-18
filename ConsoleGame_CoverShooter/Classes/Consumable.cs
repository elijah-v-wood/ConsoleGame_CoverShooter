using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Consumable
    {
        int Quantity { get; set; }


        public void UseItem()
        {
            Quantity--;
        }
    }

    public class Grenade : Consumable
    {
        public void Throw(IShooter enemy)
        {
            Random rand = new Random();
            Thread.Sleep(10);
            int shot = rand.Next(1, 21);
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.GetType().ToString()} for {shot}");
                Console.WriteLine($"takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }

        }
    }
}
