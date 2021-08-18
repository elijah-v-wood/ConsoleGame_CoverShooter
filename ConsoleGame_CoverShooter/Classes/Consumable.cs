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
        protected bool HasItem
        {
            get
            {
                if (Quantity > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void UseItem()
        {
            Quantity--;
        }
    }

    public class Grenade : Consumable
    {
        public void Throw(IEnemy enemy)
        {
            if (HasItem)
            {
                Random rand = new Random();
                Thread.Sleep(10);
                int shot = rand.Next(1, 21);
                if (enemy.InCover)
                {
                    shot += 10;
                }
                if (shot > enemy.AC)
                {
                    Thread.Sleep(10);
                    int dmg = rand.Next(1, 7);
                    if (enemy.InCover) { dmg *= 2; }
                    enemy.HP -= dmg;
                    Console.WriteLine($"you shot the {enemy.name} for {shot}");
                    Console.WriteLine($"takes {dmg} damage.");
                }
                else
                {
                    Console.WriteLine("You miss.");
                }
                UseItem();
            }
            else
            {
                Console.WriteLine("You need a grenade to use it...");
            }


        }
    }
}
