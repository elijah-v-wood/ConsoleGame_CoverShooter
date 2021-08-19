using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    
    public class BlueEnemy : IEnemy
    {
        public string name { get; } = "Blue man";
        public int dmgLowerBound { get; } = 1;
        public int dmgUpperBound { get; } = 7;

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
        public int HP { get; set; } = 15;
        public bool InCover { get; protected set; }
        public void TakeCover()
        {
            InCover = true;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot(Player player)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int shoot = rand.Next(1, 21);
            if (shoot > player.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(dmgLowerBound, dmgUpperBound);
                if (player.HasShrugOff)
                {
                    dmg -= 3;
                }
                if (dmg <= 0)
                {
                    dmg = 0;
                }
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
        public void Action4(Player player)
        { 
        }
        public void Action5(Player player)
        {
        }
        public void Action6(Player player)
        {
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }

    }
    public class RedEnemy : IEnemy
    {
        public int dmgLowerBound { get; } = 1;
        public int dmgUpperBound { get; } = 7;
        public string name { get; } = "Red man";
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
        public int HP { get; set; } = 15;
        public bool InCover { get; protected set; }
        public void TakeCover()
        {
            InCover = true;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot(Player player)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int shoot = rand.Next(1, 21);
            if (shoot > player.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(dmgLowerBound, dmgUpperBound);
                if (player.HasShrugOff)
                {
                    dmg -= 3;
                }
                if (dmg <= 0)
                {
                    dmg = 0;
                }
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
            Shoot(player);
        }

        public void Action3(Player player)
        {
            Shoot(player);
        }
        public void Action4(Player player)
        {
        }
        public void Action5(Player player)
        {
        }
        public void Action6(Player player)
        {
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }

    }
    public class YellowEnemy : IEnemy
    {
        public int dmgLowerBound { get; } = 1;
        public int dmgUpperBound { get; } = 7;

        public string name { get; } = "Yellow man";
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
        public int HP { get; set; } = 15;
        public bool InCover { get; protected set; }
        public void TakeCover()
        {
            InCover = true;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot(Player player)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int shoot = rand.Next(1, 21);
            if (shoot > player.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(dmgLowerBound, dmgUpperBound);
                if (player.HasShrugOff)
                {
                    dmg -= 3;
                }
                if (dmg <= 0)
                {
                    dmg = 0;
                }
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
            TakeCover();
        }

        public void Action2(Player player)
        {
            TakeCover();
        }

        public void Action3(Player player)
        {
            TakeCover();
        }
        public void Action4(Player player)
        {
        }
        public void Action5(Player player)
        {
        }
        public void Action6(Player player)
        {
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }
    }
    public class GreenEnemy : IEnemy
    {
        public int dmgLowerBound { get; } = 1;
        public int dmgUpperBound { get; } = 7;
        public string name { get; } = "Green man";
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
        public int HP { get; set; } = 15;
        public bool InCover { get; protected set; }
        public void TakeCover()
        {
            InCover = true;
            Console.WriteLine("The enemy takes cover!");
        }
        public void Shoot(Player player)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int shoot = rand.Next(1, 21);
            if (shoot > player.AC)
            {
                Thread.Sleep(10);
                int dmg = rand.Next(dmgLowerBound, dmgUpperBound);
                if (player.HasShrugOff)
                {
                    dmg -= 3;
                }
                if (dmg <= 0)
                {
                    dmg = 0;
                }
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
            TakeCover();
        }

        public void Action2(Player player)
        {
            Shoot(player);
        }

        public void Action3(Player player)
        {
            Shoot(player);
        }
        public void Action4(Player player)
        {
        }
        public void Action5(Player player)
        {
        }
        public void Action6(Player player)
        {
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }

    }
    public class BlueMobster : BlueEnemy, IEnemy2
    {
        public new int dmgLowerBound { get; } = 1;
        public  new int dmgUpperBound { get; } = 10;
        public new string name { get; } = "Blue Mobster";
        public new int AC
        {
            get
            {
                if (InCover)
                {
                    return 18;
                }
                else
                {
                    return 11;
                }
            }
        }
        public new int HP { get; set; } = 22;

        public void Action4(Player player)
        {
            Shoot(player);
        }
        public void Action5(Player player)
        {
            Shoot(player);
        }
        public void Action6(Player player)
        {
            TakeCover();
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }
    }
    public class RedMobster : RedEnemy, IEnemy2
    {
        public new int dmgLowerBound { get; } = 1;
        public new int dmgUpperBound { get; } = 10;
        public new string name { get; } = "Red Mobster";
        public new int AC
        {
            get
            {
                if (InCover)
                {
                    return 18;
                }
                else
                {
                    return 11;
                }
            }
        }
        public new int HP { get; set; } = 22;

        public void Action4(Player player)
        {
            Shoot(player);
        }
        public void Action5(Player player)
        {
            TakeCover();
        }
        public void Action6(Player player)
        {
            Shoot(player);
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }
    }
    public class YellowMobster : YellowEnemy, IEnemy2
    {
        public new int dmgLowerBound { get; } = 1;
        public new int dmgUpperBound { get; } = 10;
        public new string name { get; } = "Yellow Mobster";
        public new int AC
        {
            get
            {
                if (InCover)
                {
                    return 18;
                }
                else
                {
                    return 11;
                }
            }
        }
        public bool ShouldShoot
        {
            get
            {
                Random rand = new Random();
                Thread.Sleep(5);
                int rngInt = rand.Next(1, 7);
                if (rngInt == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public new int HP { get; set; } = 22;


        public new void Action1(Player player)
        {

            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }

        }

        public new void Action2(Player player)
        {
            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }
        }

        public new void Action3(Player player)
        {
            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }
        }

        public void Action4(Player player)
        {
            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }
        }
        public void Action5(Player player)
        {
            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }
        }
        public void Action6(Player player)
        {
            if (ShouldShoot)
            {
                TakeCover();
            }
            else
            {
                Shoot(player);
            }
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }
    }
    public class GreenMobster : GreenEnemy, IEnemy2
    {
        public new int dmgLowerBound { get; } = 1;
        public new int dmgUpperBound { get; } = 10;
        public new string name { get; } = "Green Mobster";
        public new int AC
        {
            get
            {
                if (InCover)
                {
                    return 18;
                }
                else
                {
                    return 11;
                }
            }
        }
        public new int HP { get; set; } = 22;

        public new void Shoot(Player player)
        {
            InCover = false;
            Random rand = new Random();
            Thread.Sleep(10);
            int GrenadeChance = rand.Next(1, 21);
            if(GrenadeChance == 1)
            {
                Thread.Sleep(10);
                int shoot = rand.Next(1, 21);
                if (player.InCover)
                {
                    shoot += 10;
                }
                if (shoot > player.AC)
                {
                    Thread.Sleep(10);
                    int dmg = rand.Next(5, 10);
                    if (player.HasShrugOff)
                    {
                        dmg -= 3;
                    }
                    if (dmg <= 0)
                    {
                        dmg = 0;
                    }
                    player.HP -= dmg;
                    Console.WriteLine($"The enemy shoots you for {shoot}.");
                    Console.WriteLine($"You take {dmg} damage.");
                }
                else
                {
                    Console.WriteLine($"The enemy shoots you for {shoot} and misses.");
                }
            }
            else
            {
                Thread.Sleep(10);
                int shoot = rand.Next(1, 21);
                if (shoot > player.AC)
                {
                    Thread.Sleep(10);
                    int dmg = rand.Next(dmgLowerBound, dmgUpperBound);
                    if (player.HasShrugOff)
                    {
                        dmg -= 3;
                    }
                    if (dmg <= 0)
                    {
                        dmg = 0;
                    }
                    player.HP -= dmg;
                    Console.WriteLine($"The enemy shoots you for {shoot}.");
                    Console.WriteLine($"You take {dmg} damage.");
                }
                else
                {
                    Console.WriteLine($"The enemy shoots you for {shoot} and misses.");
                }
            }
        }
        public new void Action1(Player player)
        {
            Shoot(player);
        }

        public new void Action2(Player player)
        {
            Shoot(player);
        }

        public new void Action3(Player player)
        {
            Shoot(player);
        }
        public void Action4(Player player)
        {
            Shoot(player);
        }
        public void Action5(Player player)
        {
            Shoot(player);
        }
        public void Action6(Player player)
        {
            Shoot(player);
        }
        public void Action7(Player player)
        {
        }
        public void Action8(Player player)
        {
        }
        public void Action9(Player player)
        {
        }
    }
    /*
    public class BlueBoss: BlueMobster, IEnemy3
    {
        public new int dmgLowerBound { get; } = 3;
        public new int dmgUpperBound { get; } = 12;
        public new string name { get; } = "Blue Boss";
        public new int AC
        {
            get
            {
                if (InCover)
                {
                    return 18;
                }
                else
                {
                    return 11;
                }
            }
        }
        public new int HP { get; set; } = 30;
        public void Action7(Player player)
        {
            Shoot(player);
        }
        public void Action8(Player player)
        {
            Shoot(player);
        }
        public void Action9(Player player)
        {
            Shoot(player);
        }
    }*/
}
