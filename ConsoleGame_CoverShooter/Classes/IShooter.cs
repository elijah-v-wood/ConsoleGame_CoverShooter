using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    interface IShooter
    {
        int AC { get; set; }
        int HP { get; set; }

        void TakeCover();
        void Shoot(Player player);
    }
}
