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
        public string Name { get; set; }
        public int Quantity { get; set; }
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
        public void SetAllGunFlagsFalse(Player player)
        {
            player.PistolFlag = false;
            player.AkimboFlag = false;
            player.SMGFlag = false;
            player.RifleFlag = false;
            player.SniperFlag = false;
            player.LMGFlag = false;
        }
        public void SetAllArmorFlagsFalse(Player player)
        {
            player.BArmorFlag = false;
            player.AArmorFlag = false;
            player.FArmorFlag = false;
        }

        public void UseItem()
        {
            Quantity--;
        }
    }

    public class Grenade : Consumable
    {
        public new string Name
        {
            get
            {
                return "Grenade";
            }
        }
        public void Throw(IEnemy enemy)
        {
            if (HasItem)
            {
                Random rand = new Random();
                Thread.Sleep(10);
                int shot = rand.Next(1, 21)+3;
                if (enemy.InCover)
                {
                    shot += 10;
                }
                if (shot > enemy.AC)
                {
                    Thread.Sleep(10);
                    int dmg = rand.Next(5, 10);
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
    public class ShrugOff : Consumable
    {
        public new string Name { get { return "Shrug-Off"; } }
        public void Boost(Player player)
        {
            if (HasItem) {
                player.HasShrugOff = true;
                UseItem();
            }
            else
            {
                Console.WriteLine("ya can't use it if you don't got it");
            }
            
        }

    }
    public class EagleEye : Consumable
    {
        public new string Name { get { return "Eagle-Eye"; } }

        public void Boost(Player player)
        {
            if (HasItem)
            {
                player.HasEagleEye = true;
                UseItem();
            }
            else
            {
                Console.WriteLine("ya can't use it if you don't got it");
            }
        }
    }
    public class Medpac : Consumable
    {
        public new string Name { get { return "Med-pac"; } }
        public void Heal(Player player)
        {
            if (HasItem)
            {
                Random rand = new Random();
                int heal = rand.Next(10, 26);
                player.HP += heal;
                UseItem();
            }
            else
            {
                Console.WriteLine("ya can't use it if you don't got it");
            }
            
        }
    }
    public class  Pistol : Consumable
    {
        public new string Name { get { return "Pistol"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.PistolFlag = true;

        }
    }
    public class Akimbo : Consumable
    {
        public new string Name { get { return "Akimbo Pistols"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.AkimboFlag = true;

        }
    }
    public class SMG : Consumable
    {
        public new string Name { get { return "Sub-machine Gun"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.SMGFlag = true;

        }
    }
    public class Rifle : Consumable
    {
        public new string Name { get { return "Rifle"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.RifleFlag = true;

        }
    }
    public class Sniper : Consumable
    {
        public new string Name { get { return "Sniper Rifle"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.SniperFlag = true;

        }
    }
    public class LMG : Consumable
    {
        public new string Name { get { return "Light Machine Gun"; } }
        public void PickUp(Player player)
        {
            SetAllGunFlagsFalse(player);
            player.LMGFlag = true;

        }
    }
    public class BasicArmor : Consumable
    {
        public new string Name { get { return "Basic Armor"; } }
        public void PickUp(Player player)
        {
            SetAllArmorFlagsFalse(player);
            player.BArmorFlag = true;

        }
    }
    public class AdvancedArmor : Consumable
    {
        public new string Name { get { return "Advanced Armor"; } }
        public void PickUp(Player player)
        {
            SetAllArmorFlagsFalse(player);
            player.AArmorFlag = true;

        }

    }
    public class FuturisticArmor : Consumable
    {
        public new string Name { get { return "Futuristic Armor"; } }
        public void PickUp(Player player)
        {
            SetAllArmorFlagsFalse(player);
            player.FArmorFlag = true;

        }

    }






}
