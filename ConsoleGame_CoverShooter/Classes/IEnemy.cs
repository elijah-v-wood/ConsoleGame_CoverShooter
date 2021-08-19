using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public interface IEnemy
    {
        
        string name { get; }
        void Action1(Player player);
        void Action2(Player player);
        void Action3(Player player);
        int AC { get; }
        int HP { get; set; }
        bool InCover { get; }

        void TakeCover();
        void Shoot(Player player);
        void Action4(Player player);
        void Action5(Player player);
        void Action6(Player player);
        void Action7(Player player);
        void Action8(Player player);
        void Action9(Player player);

    }
    public interface IEnemy2
    {
        void Action4(Player player);
        void Action5(Player player);
        void Action6(Player player);
    }
    public interface IEnemy3
    {
        void Action7(Player player);
        void Action8(Player player);
        void Action9(Player player);
    }
}
