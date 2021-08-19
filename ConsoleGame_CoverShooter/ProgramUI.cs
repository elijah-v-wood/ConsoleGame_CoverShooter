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
        private DateTime start { get; set; }
        private DateTime finish { get; set; }
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
            Inventory playerInventory = new Inventory();
            //set to one later
            playerInventory.grenade.Quantity = 5;
            Player player = new Player();
           
            List<Room> roomList = new List<Room>();

            for (int i = 0; i < 11; i++)
            {
                Room roomI = new Room(i);
                roomList.Add(roomI);
            }

            Thread.Sleep(1000);
            start = DateTime.Now;
            Console.Clear();
            bool combatActive = true;
            int turnCount = 1;
            while (combatActive)
            {
                Room currentRoom = roomList.First();
                Console.Clear();
                
                Console.WriteLine($"turn count : {turnCount}");
                Console.WriteLine($"You are fighting {currentRoom.Enemies.Count()} {currentRoom.Enemies.First<IEnemy>().name}");
                Console.WriteLine($"Enemy health is {currentRoom.Enemies.First<IEnemy>().HP}.\n" +
                    $"Your health is {player.HP}");
                Console.WriteLine("What do you want to do?:\n" +
                    "1. Shoot \n" +
                    "2. Take Cover\n"+
                    "3. Open Inventory");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                    case "shoot":
                        player.Shoot(currentRoom.Enemies.First<IEnemy>());
                        break;
                    case "2":
                    case "cover":
                    case "take cover":
                    case "takecover":
                    case "take":
                        player.TakeCover();
                        break;
                    case "3":
                    case "open":
                    case "inventory":
                    case "open inventory":
                        OpenPockets(playerInventory,currentRoom.Enemies.First<IEnemy>() );
                        break;
                    default:
                        Console.WriteLine("what are you gonna do?");
                        break;
                }
                for (int enemyindex = 0; enemyindex < currentRoom.Enemies.Count; enemyindex++)
                {
                    currentRoom.CheckHealth(currentRoom.Enemies[enemyindex]);
                    if (currentRoom.Enemies.Count > 0)
                    {
                        if (currentRoom.Enemies[enemyindex].GetType() == typeof(IEnemy3))
                        {
                            if (turnCount % 9 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action9(player);
                            }
                            else if (turnCount % 8 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action8(player);
                            }
                            else if (turnCount % 7 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action7(player);
                            }
                            else if (turnCount % 6 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action6(player);
                            }
                            else if (turnCount % 5 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action5(player);
                            }
                            else if (turnCount % 4 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action4(player);
                            }
                            else if (turnCount % 3 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action3(player);
                            }
                            else if (turnCount % 2 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action2(player);
                            }
                            else
                            {
                                currentRoom.Enemies[enemyindex].Action1(player);
                            }
                        }
                        else if(currentRoom.Enemies[enemyindex].GetType() == typeof(IEnemy2))
                        {
                            if (turnCount % 6 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action6(player);
                            }
                            else if (turnCount % 5 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action5(player);
                            }
                            else if (turnCount % 4 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action4(player);
                            }
                            else if (turnCount % 3 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action3(player);
                            }
                            else if (turnCount % 2 == 0)
                            {
                                currentRoom.Enemies[enemyindex].Action2(player);
                            }
                            else
                            {
                                currentRoom.Enemies[enemyindex].Action1(player);
                            }
                        }
                        
                        else if (turnCount % 3 == 0)
                        {
                            currentRoom.Enemies[enemyindex].Action3(player);
                        }
                        else if (turnCount % 2 == 0)
                        {
                            currentRoom.Enemies[enemyindex].Action2(player);
                        }
                        else
                        {
                            currentRoom.Enemies[enemyindex].Action1(player);
                        }
                    }
                }
                if (currentRoom.HasNoEnemies) 
                {
                    Console.WriteLine("you killed all the enemies in the room!");
                    Console.WriteLine($"You found a {currentRoom.Drop.Name}! Do you want to keep it? (y/n)");
                    string userinput = Console.ReadLine().ToLower();
                    switch (userinput)
                    {
                        case "y":
                        case "yes":
                            currentRoom.DropItem(playerInventory, player);
                            break;
                        case "n":
                        case "no":
                            Console.WriteLine("you did not pick up the item");
                            break;
                        default:
                            currentRoom.DropItem(playerInventory, player);
                            break;
                    }
                    roomList.Remove(currentRoom);
                    //you get an item

                }
                if (player.HP == 0 || roomList.Count == 0)
                {
                    combatActive = false;
                    finish = DateTime.Now;
                    TimeSpan gameplaytime = finish - start;
                    Console.WriteLine($"you finished the game in {gameplaytime.Minutes} minutes and {turnCount} turns with {player.HP} hp left");
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
        private void OpenPockets(Inventory pockets, IEnemy enemy)
        {
            Console.Clear();
            //There likely isnt a worse way to do this, but it works for now
            /**/
            Console.WriteLine("You have:");
            DisplayInventoryItem(pockets);

            Console.WriteLine("\n");
            Console.WriteLine("Input the item you wish to use or type exit");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "grenade":
                    pockets.grenade.Throw(enemy);
                    break;
                case "shrugoff":
                case "shrug off":
                case "shrug-off":
                    pockets.shrugOff.UseItem();
                    break;
                case "eagleeye":
                case "eagle-eye":
                case "eagle eye":
                    pockets.eagleEye.UseItem();
                    break;
                case "exit":
                case "close":
                case "leave":
                    break;
            }
        }
        private void DisplayInventoryItem(Inventory pockets)
        {
            if (pockets.grenade.Quantity > 0)
            {
                Console.WriteLine($"{pockets.grenade.Name} x{pockets.grenade.Quantity}");
            }
            if (pockets.shrugOff.Quantity > 0)
            {
                Console.WriteLine($"{pockets.shrugOff.Name} x{pockets.shrugOff.Quantity}");
            }
            if (pockets.eagleEye.Quantity > 0)
            {
                Console.WriteLine($"{pockets.eagleEye.Name} x{pockets.eagleEye.Quantity}");
            }
        }
    }
}
