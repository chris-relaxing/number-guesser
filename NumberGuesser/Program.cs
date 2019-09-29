using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main()
        {
            ColorMessage(ConsoleColor.Cyan, "Welcome to the \"Number Guesser\" interactive console game written in C#: ");

            // Get user's name and greet them
            GreetUser();

            // Features:
            // Random number between 1 and 100
            // Logic to say whether to go higher or lower
            // Keep a count of the number of guesses

            // To Do:
            // Keep track of each users best score (lowest number of guesses)

            while (true)
            {
                // Create a new Random object
                Random random = new Random();

                int numberRange = 100;

                // Let random choose the correct number
                int correctNumber = random.Next(1, numberRange);

                //Console.WriteLine("\nEnter a number between 1 and {0}: ({1})", numberRange, correctNumber);
                Console.WriteLine("\nEnter a number between 1 and {0}:", numberRange);
                //Console.WriteLine("\nEnter a number between 1 and 10: ");

                // Initialize the variable myGuess
                int myGuess = 0;
                int tryCount = 1;

                while (myGuess != correctNumber)
                {
                    // Get the number
                    string inputNum = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(inputNum, out myGuess))
                    {
                        // Print error message
                        ColorMessage(ConsoleColor.DarkYellow, "Only numbers will work with this game! Try again.");

                        // Keep going
                        continue;
                    }

                    // Convert the string number to an int
                    myGuess = Int32.Parse(inputNum);

                    if (myGuess != correctNumber)
                    {
                        // Reflect the number that the user chose
                        //Console.WriteLine("\n{0} is not correct. Try again.", myGuess);
                        if (myGuess < correctNumber)
                        {
                            string textMessage = "\n" + myGuess + " is not correct. Try a higher number.";
                            ColorMessage(ConsoleColor.Red, textMessage);
                        }
                        else
                        {
                            string textMessage = "\n" + myGuess + " is not correct. Try a lower number.";
                            ColorMessage(ConsoleColor.Red, textMessage);
                        }

                        tryCount += 1;
                    } 
                    else
                    {
                        string textMessage = "\nGood job! You found the correct answer (" + correctNumber + ") in " + tryCount + " tries.";
                        ColorMessage(ConsoleColor.Green, textMessage);
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
            Console.WriteLine("\nHello {0}, thanks for playing!", userName);
        }
    }
}
