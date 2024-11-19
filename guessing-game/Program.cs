using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a Random instance to generate the hidden number
        Random random = new Random();
        int hiddenNumber = random.Next(1, 101); // Random number between 1 and 100

        // Variable to store the user's guess
        int userGuess;

        // List to track previous guesses
        List<int> previousGuesses = new List<int>();

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Try to guess the hidden number between 1 and 100.");

        // do-while loop
        do
        {
            // Read input from the user
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Parse the input to an integer
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                continue; // Skip the rest of the loop and prompt again
            }

            // Check if the guess was used before
            if (previousGuesses.Contains(userGuess))
            {
                int index = previousGuesses.IndexOf(userGuess);
                int x = previousGuesses.Count - index;
                Console.WriteLine($"You guessed this number {x} turns ago!");
                continue; // Skip to the next iteration
            }

            // Add the guess to the list of previous guesses
            previousGuesses.Add(userGuess);

            // Check if the guess is higher, lower, or correct
            if (userGuess > hiddenNumber)
            {
                Console.WriteLine("Too High! Try again.");
            }
            else if (userGuess < hiddenNumber)
            {
                Console.WriteLine("Too Low! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
            }

        } while (userGuess != hiddenNumber); // Exit loop only if the guess is correct

        // Message after the loop
        Console.WriteLine($"You Won! The answer was {hiddenNumber}.");
    }
}
