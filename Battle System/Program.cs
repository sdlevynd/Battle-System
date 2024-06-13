using Battle_System.Classes;
using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;

namespace Battle_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player = PlayerSetup();

            Console.WriteLine($"Welcome, {player.GetName()}!");
            Console.WriteLine($"You have a {player.GetWeaponName()}, it is {player.GetWeaponDescription()}");

            Enemy enemy = new Skeleton();

            while (true)
            {
                
            }
        }

        static Player PlayerSetup()
        {
            string playerName = PresenceCheck("Enter your name");

            string playerClassChoice = PresenceCheck("Select your class from the list below:\n" +
                "1: ...\n" +
                "2: ...\n" +
                "3: ...");
            Console.WriteLine("Class selection has not been implemented yet");

            Player player = new Player(playerName);
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
    }
}