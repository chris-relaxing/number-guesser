using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nunber Guesser ");
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            // Set text color
            Console.ForegroundColor = color;

            // Set message
            Console.WriteLine(message);

            // Reset text color

        }
    }
}
