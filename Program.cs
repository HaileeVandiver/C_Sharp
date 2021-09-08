using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //Create a one-dimensional Array of integers. Ask the user to select an index of the Array
        //and then display the integer at that index on the screen.
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        Console.WriteLine("select an index between 0 and 6");
        string strNumber = Console.ReadLine();
        int intNumber = Convert.ToInt32(strNumber);
        if (intNumber > 6)
        {
            //message that displays when the user selects an index that doesn’t exist
            Console.WriteLine("That index is out of bounds");
        }
        else
        {
            Console.WriteLine("The number at index " + intNumber + " is: " + numArray2[intNumber]);
            Console.ReadLine();
        }
        

        //Create a one-dimensional Array of strings.Ask the user to select an index of the
        //Array and then display the string at that index on the screen.
        string[] strArray1 = { "goodnight", "unto", "you", "all" };
        Console.WriteLine("select an index between 0 and 3");
        string select = Console.ReadLine();
        int intSelect = Convert.ToInt32(select);
        if (intSelect > 3)
        {
            //message that displays when the user selects an index that doesn’t exist
            Console.WriteLine("That index is out of bounds");
            Console.ReadLine(); 
        }

        else
        {
            Console.WriteLine("The string at index " + intSelect + " is: " + strArray1[intSelect]);
            Console.ReadLine();
        }
        //Create a list of strings.
        //Ask the user to select an index of the list and then display the content at that index on the screen.
        List<string> myList = new List<string>();
        myList.Add("Dustfinger");
        myList.Add("Ampona");
        myList.Add("Beavik");
        myList.Add("Adam");

        Console.WriteLine("Select and index between 0 and 3 ");
        string selectTwo = Console.ReadLine();
        int intSelectTwo = Convert.ToInt32(selectTwo); 

        if (intSelectTwo < 3)
        {
            Console.WriteLine("The string at index " + intSelectTwo + " is: " + myList[intSelectTwo]);
        }
        else
        {
            Console.WriteLine("Index does not exist");
        }
        Console.ReadLine();
    }

}


