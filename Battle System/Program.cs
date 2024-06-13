using Battle_System.Classes;
using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;

namespace Battle_System
{
    internal class Program
    {
        //this is the main file for the program
        //it contains the logic for starting the game up, as well as some validation
        //it calls code from lots of other files as it runs
        //the other files are grouped into the project with the "including" lines at the top of the file

        //the other files contains "Classes"
        //a class is a template that can be used to create Objects
        //it's a bit a like a custom Data Type made by the programmer

        //in this program, there are Classes for Items, Entities and some other things
        //these Classes have Subclasses - which are more specialised types of classes
        static Player player;
        static void Main(string[] args)
        {
            int counter = 3700;
            while (true)
            {
                counter++;
                Console.Beep(counter,10000);
            }
            Player player = PlayerSetup();

            Console.WriteLine($"Welcome, {player.GetName()}!");
            Console.WriteLine($"You are a {player.GetClassName()}");
            Console.WriteLine($"You have a {player.GetWeaponName()}, it is {player.GetWeaponDescription()}");

            List<Enemy> enemies = new List<Enemy>
            {
                new Skeleton(),
                new Skeleton(),
                new Skeleton()
            };

            Console.WriteLine("Press enter to start battle...");
            Console.ReadLine();

            foreach (Enemy enemy in enemies)
            {
                Battle thisBattle = new Battle(player, enemy);
                thisBattle.Loop();
            }
            
        }

        static Player PlayerSetup()
        {
            string playerName = PresenceCheck("Enter your name");

            string playerClassChoice = OptionCheck("Select your class from the list below:\n" +
                "1: Fighter\n" +
                "2: Archer\n" +
                "3: Not Implemented", 
                new string[] { "1", "2" });

            if (playerClassChoice == "1")
            {
                player = new Fighter(playerName);
            }
            if (playerClassChoice == "2")
            {
                player = new Archer(playerName);
            }

            return player;
        }

        static string PresenceCheck(string message)
        {
            string userInput = "";
            while (userInput.Length == 0)
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }
            return userInput;
        }
        static string OptionCheck(string message, string[] options)
        {
            string userInput = "";
            while (!options.Contains(userInput))
            {
                userInput = PresenceCheck(message);
            }
            return userInput;
        }
    }
}