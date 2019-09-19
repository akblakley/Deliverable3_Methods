/* 
 * Author: Amanda Blakley
 * Date: 9/19/2019
 * Description: This C# console application code demonstrates the use of
 * methods after getting input from a user.
*/

using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Display a message welcoming the user
                // and ask them to enter their name 
                Console.WriteLine("Welcome to USF!");
                Console.WriteLine();
                Console.WriteLine("___________________________");
                Console.WriteLine();
                Console.WriteLine("Please state your name...");
                Console.WriteLine();

                // Gather the user's input 
                string yourName = Console.ReadLine();

                // Display a message saying 'hello' to the user
                Console.WriteLine();
                Console.WriteLine("Hello " + yourName + " ! ");
                Console.WriteLine();
                Console.WriteLine("Are you enjoying USF?");
                Console.WriteLine();
                Console.WriteLine("Press 1 for 'Yes' and 2 for 'No'");
                Console.WriteLine();

                // Declare variables 
                int result;

                if (int.TryParse(Console.ReadLine(), out result))
                {
                    /* Start the IF/ELSE IF/ELSE block to display the 
                     * message that corresponds to the input 
                    */

                    if (result == 1)
                    {
                        Console.WriteLine("___________________________");
                        Console.WriteLine();
                        Console.WriteLine("Awesome! Go Bulls!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to exit and start again...");
                        Console.ReadKey(true);
                    }
                    else if (result == 2)
                    {
                        Console.WriteLine("___________________________");
                        Console.WriteLine();
                        Console.WriteLine("I'm sorry to hear that. I hope tomorrow is a better day!");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to exit and start again...");
                        Console.ReadKey(true);
                    }
                    else if (result >= 3)
                    {
                        Console.WriteLine("___________________________");
                        Console.WriteLine();
                        Console.WriteLine("Sorry, this is an incorrect response! Enter only 1 or 2...");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to exit and start again...");
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("___________________________");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}
