using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How mcuh money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                //adding player to the game
                game += player;
                player.isActivelyPlaying = true; 
                //check if playing and has money 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); 
                }
                //game is over so take out player 
                game -= player;
                Console.WriteLine("Thank you for playing!"); 
            }
            Console.WriteLine("See you again soon!");
            Console.Read(); 
            
        }
       
       
    }
}
