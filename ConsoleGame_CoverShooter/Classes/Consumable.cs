using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
