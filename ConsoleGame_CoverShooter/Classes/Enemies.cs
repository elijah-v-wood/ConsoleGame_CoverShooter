﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class BlueEnemy : IEnemy, IShooter
    {
        public int AC { get; set; } = 10;
        public int HP { get; set; } = 15;
        public void TakeCover()
        {
            AC = 17;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot(Player player)
        {
            AC = 10;
            Random rand = new Random();
            Thread.Sleep(10);
            int shoot =rand.Next(1, 21);
            if (shoot > player.AC)
            {
                Thread.Sleep(10);
                int dmg= rand.Next(1, 7);
                player.HP -= dmg;
                Console.WriteLine($"The enemy shoots you for {shoot}.");
                Console.WriteLine($"You take {dmg} damage.");
            }
            else
            {
                Console.WriteLine($"The enemy shoots you for {shoot} and misses.");
            }
        }
        public void Action1(Player player)
        {
            Shoot(player);
        }

        public void Action2(Player player)
        {
            TakeCover();
        }

        public void Action3(Player player)
        {
            TakeCover();
        }


    }
}
