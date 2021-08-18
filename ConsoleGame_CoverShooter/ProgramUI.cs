using ConsoleGame_CoverShooter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter
{
    class ProgramUI
    {
        bool isRunning = true;
        public void Run()
        {
            do
            {
                Menu();

            }
            while (isRunning);
        }


        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to Cover Shooter!");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Please select an option below.");
            Console.WriteLine("1. Start 2. Instructions 3. Exit");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                case "start":
                    Game();
                    break;
                case "2":
                case "instructions":
                    Instruct();
                    break;
                case "3":
                case "exit":
                    Exit();
                    break;
                default:
                    Console.WriteLine("unregistered input, closing program");
                    Exit();
                    break;
            }
        }
        private void Game()
        {
            Console.WriteLine("Starting the game...");
            Player player = new Player();
            Room firstRoom = new Room();
            Thread.Sleep(1000);
            Console.Clear();
            bool combatActive = true;
            int turnCount = 1;
            while (combatActive)
            {
                Console.Clear();
                Console.WriteLine($"turn count : {turnCount}");
                Console.WriteLine($"You are fighting {firstRoom.Enemies.Count()} {firstRoom.Enemies.First<IEnemy>().name}");
                Console.WriteLine($"Enemy health is {firstRoom.Enemies.First<IEnemy>().HP}.\n" +
                    $"Your health is {player.HP}");
                Console.WriteLine("What do you want to do?:\n" +
                    "1. Shoot \n" +
                    "2. Take Cover");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                    case "shoot":
                        player.Shoot(firstRoom.Enemies.First<IEnemy>());
                        break;
                    case "2":
                    case "cover":
                    case "take cover":
                    case "takecover":
                    case "take":
                        player.TakeCover();
                        break;
                    default:
                        Console.WriteLine("what are you gonna do?");
                        break;
                }
                Console.ReadKey();
                for (int enemyindex = 0; enemyindex < firstRoom.Enemies.Count; enemyindex++)
                {
                    firstRoom.CheckHealth(firstRoom.Enemies[enemyindex]);
                    if (firstRoom.Enemies.Count > 0)
                    {

                        if (turnCount % 3 == 0)
                        {
                            firstRoom.Enemies[enemyindex].Action3(player);
                        }
                        else if (turnCount % 2 == 0)
                        {
                            firstRoom.Enemies[enemyindex].Action2(player);
                        }
                        else
                        {
                            firstRoom.Enemies[enemyindex].Action1(player);
                        }
                    }
                }
                if (player.HP == 0 || firstRoom.HasNoEnemies)
                {
                    combatActive = false;
                }


                Console.ReadKey();
                turnCount++;
            }
        }
        private void Instruct()
        {
            Console.Clear();
            Console.WriteLine("Cover Shooter is a turn-based roguelike.\n"
                + "The objective of the game is clear each level as fast as possible to try to get the best time.\n"
                + "Below are some instructions to help you accomplish this goal.");

            Console.WriteLine("\n");

            Console.WriteLine("HitPoints(or HP):"
                + "How much health you have. Lose it all and it's game over!");

            Console.WriteLine("\n");

            Console.WriteLine("Armor Class: sometimes called AC.\n"
                + "This values is how hard it is to hit you.");

            Console.WriteLine("\n");

            Console.WriteLine("Shoot: Simply put. Shoot the enemy.\n" +
                "The game will roll a number and check it against the enemy's Armor Class.\n"
                + "If you roll higher than their AC, its a hit and you'll do some damage to the enemies health!");

            Console.WriteLine("\n");

            Console.WriteLine("Press any key to return to the Menu...");
            Console.ReadKey();
        }
        private void Exit()
        {
            Console.WriteLine("Good-bye!");
            Thread.Sleep(100);
            isRunning = false;
        }
    }
}
