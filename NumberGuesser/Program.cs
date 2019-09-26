using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorMessage(ConsoleColor.Cyan, "Welcome to the \"Number Guesser\" interactive console experience: ");

            // Get user's name and greet them
            GreetUser();

            Console.WriteLine("\nEnter a number between 1 and 10:");

            // Get the number
            string inputNum = Console.ReadLine();

            int myGuess = 0;
            myGuess = Int32.Parse(inputNum);

            Console.WriteLine("\nYou chose the number {0}", myGuess);
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            // Set text color
            Console.ForegroundColor = color;

            // Set message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask for user's name
            Console.WriteLine("\nWhat is your name?");

            // Get the user's name
            string userName = Console.ReadLine();

            // Use substitution in a string for the greeting
            Console.WriteLine("\nHello {0}, are you ready to play? :)", userName);
        }
    }
}
