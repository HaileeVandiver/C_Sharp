using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()

        //Create a one-dimesional Array of strings. Ask user to input some text. Create a loop that goes through each string in the Array, 
        //adding the user's text to the string. Then create a loop that prints off each string in the Array on a separate line.
        {
            string[] strArray = { "cat", "dog", "salamander", "inuyasha" };
            Console.WriteLine("Please input some text");
            string newText = Console.ReadLine();

            for (int i = 0; i < strArray.Length; i++)
            {
                string addNewText = strArray[i] + " " + newText;
                Console.WriteLine(addNewText + "\n");
            }
            Console.ReadLine();

            //-------Create an infinite loop------------
            //string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            //for( ; ; )
            //{
            //    Console.WriteLine("Infinite.");
            //}

            //-------Fix an infinite loop----------------
            string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            for (int i = 0; i < infinite.Length; i++)
            {
                Console.WriteLine(infinite[i]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.
            int[] tacos = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < tacos.Length; i++)
            {
                Console.WriteLine(tacos[i]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(tacos[i]);
            }
            Console.ReadLine();

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            string[] uniqueArray = { "inuyasha", "kagome", "kikyo", "sesshomaru" };
            Console.WriteLine("Input inuyasha, kagome, kikyo, or sesshomaru to search list");
            string searchInput = Console.ReadLine();

            for (int i = 0; i < uniqueArray.Length; i++)
            {
                if (uniqueArray[i].Contains(searchInput))
                {
                    Console.WriteLine("The index of " + searchInput + " is " + i);
                    Console.ReadLine();
                    System.Environment.Exit(0);



                }
                else if (!uniqueArray[i].Contains(searchInput))
                {
                    Console.WriteLine("Sorry, that isn't part of the list");
                    System.Environment.Exit(0);



                }


            }
            

           //A list of strings that has at least two identical strings in the list.
           //Ask the user to select text to search for in the list.   

           List<string> dupList = new List<string>()
            {
                "gandalf",
                "frodo",
                "samwise",
                "aragorn",
                "gandalf"
            };

            List<string> reList = new List<string>();

            Console.WriteLine("Select either gandalf, frodo, samwise, or aragorn");
            string userInput = Console.ReadLine(); 

            for (int i = 0; i < dupList.Count; i++)
            {
                if (dupList[i].Contains(userInput))
                {
                    Console.WriteLine("The index of " + userInput + " is " + i);
                    Console.ReadLine();
                    System.Environment.Exit(0);



                }
                else if (!dupList[i].Contains(userInput))
                {
                    Console.WriteLine("Sorry, that isn't part of the list");
                    System.Environment.Exit(0);



                }


            }
            // loop adds a name to the nameRepeat List and then checks to see if the name is already in the list
            foreach (string name in dupList)
            {
                if (reList.Contains(name))
                {
                    reList.Add(name);
                    Console.WriteLine("The name " + name + " has already appeared in the list!");
                }
                else
                {
                    reList.Add(name);
                    Console.WriteLine("This name " + name + " has not appeared in the list yet!");

                }
            }
            Console.ReadLine();






        }
    }
}
    

