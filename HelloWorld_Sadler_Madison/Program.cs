// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace HelloWorld_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Asks the user for first name
            Console.WriteLine("What is your first name?");
            // Asigns user input to firstName variable
            string firstName = Console.ReadLine();
            // Asks the user for last name
            Console.WriteLine("What is your last name?");
            // Assigns user input to lastName variable
            string lastName = Console.ReadLine();

            // Asks the user if that is their name
            Console.WriteLine($"So your name is {firstName} {lastName}?");
            // Assigns user input to trueName variable
            string trueName = Console.ReadLine();

            // Asks the user what their social security number is as a joke
            Console.WriteLine($"Now... What is your social security number?");
            // Tells user it's kidding and welcomes user with firstName and lastName
            Console.WriteLine($"Just kidding! Nice to meet you, {firstName} {lastName}!");
        }
    }
}
