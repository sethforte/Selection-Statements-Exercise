﻿namespace SelectionStatementExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a random number generator
            var random = new Random();
            var favoriteNumber = random.Next(1, 1000); // Generate a random number between 1 and 1000

            Console.WriteLine("Try to guess the favorite number (between 1 and 1000):");

            while (true)
            {
                Console.Write("Enter your guess: ");
                var input = Console.ReadLine();

                // Validate user input
                if (int.TryParse(input, out int userGuess))
                {
                    if (userGuess == favoriteNumber)
                    {
                        Console.WriteLine("You guessed the correct number!");
                        break;
                    }
                    else if (userGuess < favoriteNumber)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }


            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math is a great subject! What do you like about it?.");
                    break;
                case "Science":
                    Console.WriteLine("Science is a great subject! What do you like about it?.");
                    break;
                case "History":
                    Console.WriteLine("History is a great subject! What do you like about it?.");
                    break;
                case "English":
                    Console.WriteLine("English is a great subject! What do you like about it?.");
                    break;
                case "Art":
                    Console.WriteLine("Art is a great subject! What do you like about it?.");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}
