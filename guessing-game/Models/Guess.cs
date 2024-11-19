using System;

namespace guessing_game.Models
{
    public class Guess
    {
        // Properties
        public int GuessedNumber { get; private set; } // Represents the user's guess
        public DateTime GuessTime { get; private set; } // Represents the time of the guess

        // Constructor
        public Guess(int userGuess)
        {
            GuessedNumber = userGuess; // Assign the user's guess to the Guess property
            GuessTime = DateTime.Now; // Set the GuessTime property to the current time
        }

        // Overrides ToString for a user-friendly display
        public override string ToString()
        {
            return $"Guess: {GuessedNumber}, Time: {GuessTime}";
        }
    }
}
