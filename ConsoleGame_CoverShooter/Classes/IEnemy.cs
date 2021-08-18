using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public interface IEnemy
    {

        void Action1(Player player);
        void Action2(Player player);
        void Action3(Player player);

    }
}
