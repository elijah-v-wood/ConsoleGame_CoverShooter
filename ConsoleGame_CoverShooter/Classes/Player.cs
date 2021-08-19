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
                    if (BArmorFlag) { return 19; }
                    else if (AArmorFlag) { return 20; }
                    else if (FArmorFlag) { return 22; }
                    else { return 17; }
                }
                else
                {
                    if (BArmorFlag) { return 12; }
                    else if (AArmorFlag) { return 13; }
                    else if (FArmorFlag) { return 15; }
                    else { return 10; }
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
        //ArmorFlags
        public bool BArmorFlag { get; set; }
        public bool AArmorFlag { get; set; }
        public bool FArmorFlag { get; set; }

        public void Shoot(IEnemy enemy)
        {
            InCover = false;
            if (PistolFlag)
            {
                Pistol(enemy);
            }
            else if (AkimboFlag)
            {
                Akimbo(enemy);
            }
            else if (SMGFlag)
            {
                SMG(enemy);
            }
            else if (SniperFlag)
            {
                Sniper(enemy);
            }
            else if (RifleFlag)
            {
                Rifle(enemy);
            }
            else if (LMGFlag)
            {
                LMG(enemy);
            }
            else
            {
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
            
        }

        public void TakeCover()
        {
            InCover = true;
            Console.WriteLine("you take cover!");
        }

        public void Pistol(IEnemy enemy)
        {
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
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your pistol.");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }
        public void Akimbo(IEnemy enemy)
        {
            Pistol(enemy);
            Pistol(enemy);
        }
        public void SMG(IEnemy enemy)
        {
            Random rand = new Random();
            Thread.Sleep(10);
            int shot;
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 8;
            }
            else
            {
                shot = rand.Next(1, 21) + 4;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your SMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            Thread.Sleep(10);
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 8;
            }
            else
            {
                shot = rand.Next(1, 21) + 4;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your SMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            Thread.Sleep(10);
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 8;
            }
            else
            {
                shot = rand.Next(1, 21) + 4;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your SMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }
        public void Rifle(IEnemy enemy)
        {
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
                int dmg = rand.Next(3, 9);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your Rifle");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
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
                int dmg = rand.Next(3, 9);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your Rifle");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }
        public void Sniper(IEnemy enemy)
        {
            Random rand = new Random();
            Thread.Sleep(10);
            int shot;
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 9;
            }
            else
            {
                shot = rand.Next(1, 21) + 5;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(5, 21);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your Sniper Rifle");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }
        public void LMG(IEnemy enemy)
        {
            Random rand = new Random();
            Thread.Sleep(10);
            int shot;
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
            if (HasEagleEye)
            {
                shot = rand.Next(1, 21) + 6;
            }
            else
            {
                shot = rand.Next(1, 21) + 2;
            }
            if (shot > enemy.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(1, 7);
                enemy.HP -= dmg;
                Console.WriteLine($"you shot the {enemy.name} for {shot} with your LMG");
                Console.WriteLine($"{enemy.name} takes {dmg} damage.");
            }
            else
            {
                Console.WriteLine("You miss.");
            }
        }

    }
}
