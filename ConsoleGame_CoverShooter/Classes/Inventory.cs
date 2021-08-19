using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Inventory
    {
        public List<Consumable> _playerInventory = new List<Consumable>();
        public Grenade grenade = new Grenade();
        public ShrugOff shrugOff = new ShrugOff();
        public EagleEye eagleEye = new EagleEye();
        public Medpac medpac = new Medpac();
        public Pistol pistol = new Pistol();
        public Akimbo akimbo = new Akimbo();
        public SMG smg = new SMG();
        public Sniper sniper = new Sniper();
        public Rifle rifle = new Rifle();
        public LMG lmg = new LMG();
        public BasicArmor bArmor = new BasicArmor();
        public AdvancedArmor aArmor = new AdvancedArmor();
        public FuturisticArmor fArmor = new FuturisticArmor();

        public void PickUp(Consumable item, Player player)
        {
            //if not a gun or armor
            if (item.GetType() != new Pistol().GetType() || item.GetType() != new Akimbo().GetType() || item.GetType() != new SMG().GetType() || item.GetType() != new Sniper().GetType() || item.GetType() != new Rifle().GetType() || item.GetType() != new LMG().GetType() || item.GetType() != new BasicArmor().GetType() || item.GetType() != new AdvancedArmor().GetType() || item.GetType() != new FuturisticArmor().GetType())
            {
            item.Quantity++;
            }
            else if(item.GetType()==new Pistol().GetType())
            {
                pistol.PickUp(player);
            }
            else if (item.GetType() == new Akimbo().GetType())
            {
                akimbo.PickUp(player);
            }
            else if (item.GetType() == new SMG().GetType())
            {
                smg.PickUp(player);
            }
            else if (item.GetType() == new Sniper().GetType())
            {
                sniper.PickUp(player);
            }
            else if (item.GetType() == new Rifle().GetType())
            {
                rifle.PickUp(player);
            }
            else if (item.GetType() == new LMG().GetType())
            {
                lmg.PickUp(player);
            }
            else if(item.GetType()==new BasicArmor().GetType())
            {
                bArmor.PickUp(player);
            }
            else if (item.GetType() == new AdvancedArmor().GetType())
            {
                aArmor.PickUp(player);
            }
            else if (item.GetType() == new FuturisticArmor().GetType())
            {
                fArmor.PickUp(player);
            }
            else
            {
                Console.WriteLine("You failed to pick up the item.");
            }
        }
        public void DisplayInventory()
        {
            foreach(Consumable item in _playerInventory)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"{item.Name}x{item.Quantity}");
                }
            }
        }
    }
}
