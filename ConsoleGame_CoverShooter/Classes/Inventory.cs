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

        public void PickUp(Consumable item)
        {
            //if not a gun or armor
            if (item.GetType() != new Pistol().GetType() || item.GetType() != new Akimbo().GetType() || item.GetType() != new SMG().GetType() || item.GetType() != new Sniper().GetType() || item.GetType() != new Rifle().GetType() || item.GetType() != new LMG().GetType() || item.GetType() != new BasicArmor().GetType() || item.GetType() != new AdvancedArmor().GetType() || item.GetType() != new FuturisticArmor().GetType())
            {
            item.Quantity++;
            }
            else if(item.GetType() == new Pistol().GetType() || item.GetType() == new Akimbo().GetType() || item.GetType() == new SMG().GetType() || item.GetType() == new Sniper().GetType() || item.GetType() == new Rifle().GetType() || item.GetType() == new LMG().GetType())
            {
                
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
