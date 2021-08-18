using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("Welcome to Cover Shooter!");
            Console.WriteLine("\n Cover Shooter is a turn-based rogue-like game.");
            Console.WriteLine("Please select an option below.");
            Console.WriteLine("1. Start 2. Instructions 3. Exit");
            string userInput=Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "1":
                case "start":
                    //Game();
                    break;
                case "2":
                case "instructions":
                    break;
                case "3":
                case "exit":
                    isRunning = false;
                    break;
            }
        }
    }
}
