using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Grand Hotel and Casino. What is your name?");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            
     
           
            
            
            Console.WriteLine("Hello, {0}. Would you like to play 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C: \Users\haile\Documents\GitHub\C#\TwentyOne\logs.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                //adding player to the game
                game += player;
                player.isActivelyPlaying = true;

                //check if playing and has money 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();

                    }
                    catch(FraudException ex)
                    {
                        Console.WriteLine("Security kick this person out!");
                        UpdateDbWithException(ex);
              
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error. Please contact system admin");
                        UpdateDbWithException(ex);
                        return;
                    }


                }
                    
                //game is over so take out player 
                game -= player;
                Console.WriteLine("Thank you for playing!"); 
            }
            Console.WriteLine("See you again soon!");
            Console.Read(); 
            
        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                 (@ExcpetionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExcpetionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExcpetionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

       
       
    }
}
