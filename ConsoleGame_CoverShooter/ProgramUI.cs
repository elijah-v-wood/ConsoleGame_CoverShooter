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
            string userInput=Console.ReadLine().ToLower();

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
            }
        }
        private void Game()
        {
            Console.Clear();

        }
        private void Instruct()
        {
            Console.Clear();
            Console.WriteLine("Cover Shooter is a turn-based roguelike.\n"
                +"The objective of the game is clear each level as fast as possible to try to get the best time.\n"
                +"Below are some instructions to help you accomplish this goal.");

            Console.WriteLine("\n");

            Console.WriteLine("HitPoints(or HP):"
                +"How much health you have. Lose it all and it's game over!");

            Console.WriteLine("\n");

            Console.WriteLine("Armor Class: sometimes called AC.\n" 
                +"This values is how hard it is to hit you.");

            Console.WriteLine("\n");

            Console.WriteLine("Shoot: Simply put. Shoot the enemy.\n"+ 
                "The game will roll a number and check it against the enemy's Armor Class.\n"
                +"If you roll higher than their AC, its a hit and you'll do some damage to the enemies health!");

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
