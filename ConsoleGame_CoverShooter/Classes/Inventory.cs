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

        public void PickUp(Consumable item)
        {
            item.Quantity++;
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
