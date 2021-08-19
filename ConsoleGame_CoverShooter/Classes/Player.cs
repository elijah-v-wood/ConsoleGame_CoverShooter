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
        public bool InCover { get; set; }
        public int AC
        {
            get
            {
                if (InCover)
                {
                    return 17;
                }
                else
                {
                    return 10;
                }
            }
        }

        public int HP { get; set; } = 50;
        public bool HasShrugOff { get; set; }
        public bool HasEagleEye { get; set; }

        //gunflags

        public bool PistolFlag { get; set; }
        public bool AkimboFlag { get; set; }
        public bool SMGFlag { get; set; }
        public bool SniperFlag { get; set; }
        public bool RifleFlag { get; set; }
        public bool LMGFlag { get; set; }

        public void Shoot(IEnemy enemy)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int shot;
            if (HasEagleEye)
            {
            shot = rand.Next(1, 21) + 7;
            }
            else
            {
            shot = rand.Next(1, 21) + 3;
            }
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
            InCover = true;
            Console.WriteLine("you take cover!");
        }
    }
}
