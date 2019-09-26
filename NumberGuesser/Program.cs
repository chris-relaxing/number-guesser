using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main()
        {
            ColorMessage(ConsoleColor.Cyan, "Welcome to the \"Number Guesser\" interactive console experience: ");

            // Get user's name and greet them
            GreetUser();

            while (true)
            {
                // Create a new Random object
                Random random = new Random();

                // Let random choose the correct number
                int correctNumber = random.Next(1, 10);

                Console.WriteLine("\nEnter a number between 1 and 10: ({0})", correctNumber);

                // Initialize the variable myGuess
                int myGuess = 0;

                while (myGuess != correctNumber)
                {
                    // Get the number
                    string inputNum = Console.ReadLine();                   

                    // Convert the string number to an int
                    myGuess = Int32.Parse(inputNum);

                    if (myGuess != correctNumber)
                    {
                        // Reflect the number that the user chose
                        //Console.WriteLine("\n{0} is not correct. Try again.", myGuess);

                        string textMessage = "\n" + myGuess + " is not correct. Try again.";
                        ColorMessage(ConsoleColor.Red, textMessage);
                    }
                    
                }



            }


        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            // Set text color
            Console.ForegroundColor = color;

            // Write message
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
