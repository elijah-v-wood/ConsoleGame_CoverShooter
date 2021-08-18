using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Room
    {
        public List<IEnemy> Enemies { get; set; }

        public bool HasNoEnemies
        {
            get
            {
                if (Enemies.Count() < 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //private Item Drop {get; set; }

        /*
         * for when we implement the item class later
        public void DropItem(Player player)
        {
            player.inventory.Add(Drop);
        }
         */

        public Room(List<IEnemy> enemylist /*, Item drop*/)
        {
            Enemies = enemylist;
            //Drop = drop;
        }

    }
}
