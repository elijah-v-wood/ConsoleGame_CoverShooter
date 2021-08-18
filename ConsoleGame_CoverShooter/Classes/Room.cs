using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public class Room
    {
        public List<IEnemy> Enemies { get; set; }

        public void CheckHealth(IEnemy enemy)
        {
            if (enemy.HP <= 0)
            {
                Enemies.Remove(enemy);
            }

        }

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
        //private Consumable Drop {get; set; }

        /*
         * for when we implement the item class later
        public void DropItem(Player player)
        {
            player.inventory.Add(Drop);
        }
         */

        public Room( /*int enemynumber Consumable drop*/)
        {
            IEnemy[] PossibleEnemies = { new BlueEnemy(), new RedEnemy(), new YellowEnemy(), new GreenEnemy() };
            int enemynumber = 1; // remove later when we add to the constructor
            Enemies = new List<IEnemy>();
            Random randy = new Random();
            for (int i = 0; i < enemynumber; i++)
            {
                Thread.Sleep(5);
                int enemyIndex = randy.Next(0, PossibleEnemies.Length);
                Enemies.Add(PossibleEnemies[enemyIndex]);
            }

            //Drop = drop;
        }

    }
}
