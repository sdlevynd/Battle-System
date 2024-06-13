using Battle_System.Classes;
using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;

namespace Battle_System
{
    internal class Program
    {
        static Player player;
        static void Main(string[] args)
        {

            Player player = PlayerSetup();

            Console.WriteLine($"Welcome, {player.GetName()}!");
            Console.WriteLine($"You are a {player.GetClassName()}");
            Console.WriteLine($"You have a {player.GetWeaponName()}, it is {player.GetWeaponDescription()}");

            Enemy enemy = new Skeleton();

            Console.WriteLine("Press enter to start battle...");
            Console.ReadLine();

            Battle thisBattle = new Battle(player, enemy);
            thisBattle.Loop();
        }

        static Player PlayerSetup()
        {
            string playerName = PresenceCheck("Enter your name");

            string playerClassChoice = OptionCheck("Select your class from the list below:\n" +
                "1: Fighter\n" +
                "2: Not Implemented\n" +
                "3: Not Implemented", 
                new string[] { "1" });

            if (playerClassChoice == "1")
            {
                player = new Fighter(playerName);
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