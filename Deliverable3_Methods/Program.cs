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
            Console.WriteLine("Welcome to USF! May I ask you a few questions?");

            try
            {
                // Declare variables 
                int input_age;
                string name;

                // Prompt the user to enter their name 
                Console.WriteLine("Please enter your name...");

                // Allow the user to enter their name  
                name = Console.ReadLine();

                // Display a message saying "Hello" to the user
                Console.WriteLine("Hello " + name);

                // Prompt the user to enter their age 
                Console.WriteLine("What is your age..?");
                input_age = Convert.ToInt32(Console.ReadLine());

                // This if statement test's to see if the input is between 18 and 100
                if ((input_age > 17) && input_age <= 100))
                {
                    // Display a message stating the user's age
                    Console.WriteLine("Your age is: " + input_age);
                }
                else
                {
                    Console.WriteLine("You must enter an age between 1 and 100");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.ReadKey(true);
            }
            Console.WriteLine("Thank you!");
            Console.WriteLine("Press any key to exit the program: ");
            Console.ReadKey(true);
        }
    }
}
