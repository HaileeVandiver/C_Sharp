using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of integers
        List<int> myList = new List<int>
        {
            1,
            2,
            3,
            500,
            666,
            321
        };
        //ask the user for a number to divide each number in the list by
       

        
        try {
            Console.WriteLine("pick a number to divide each number in this magical list by");
            int userNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i] / userNum);
                Console.ReadLine();
            }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            Console.WriteLine("We have emerged froom the try catch block");
            Console.ReadLine();
            }
        }
        

}


