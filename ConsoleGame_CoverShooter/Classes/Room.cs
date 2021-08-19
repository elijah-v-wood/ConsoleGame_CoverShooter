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
        private Consumable Drop { get; set; }

        public void DropItem(Inventory inventory)
        {
            inventory.PickUp(Drop);
        }

        public Room(int roomNumber /*, int enemynumber */)
        {
            IEnemy[] PossibleEnemies = { new BlueEnemy(), new RedEnemy(), new YellowEnemy(), new GreenEnemy() };
            Random randy = new Random();
            Thread.Sleep(5);
            int enemynumber = 1;
            if (roomNumber > 5)
            {
                enemynumber = randy.Next(1, 3);
                if (enemynumber < 2)
                {
                    IEnemy[] PossibleEnemiesOverride = { new BlueMobster(), new RedMobster(), new YellowMobster(), new GreenMobster() };
                    PossibleEnemies = PossibleEnemiesOverride;
                }
            }
            Enemies = new List<IEnemy>();
            for (int i = 0; i < enemynumber; i++)
            {
                Thread.Sleep(5);
                int enemyIndex = randy.Next(0, PossibleEnemies.Length);
                Enemies.Add(PossibleEnemies[enemyIndex]);
            }
            Thread.Sleep(5);
            int itemChance = randy.Next(1, 101);
            Consumable drop;
            if (itemChance < 51)
            {
                drop = new Grenade();
            }
            else if (itemChance < 76)
            {
                drop = new ShrugOff();
            }
            else
            {
                drop = new EagleEye();
            }
            Drop = drop;
        }

    }
}
