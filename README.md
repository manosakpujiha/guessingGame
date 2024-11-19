# **Guessing Game**

A simple console-based guessing game built with .NET 8. The application challenges the user to guess a hidden number between 1 and 100 while providing interactive feedback and tracking guess history with timestamps.

---

## **Features**

- **Random Number Generation**: Generates a random hidden number between 1 and 100 for each game session.
- **Interactive Feedback**:
  - Informs the user if the guess is **"Too High"** or **"Too Low."**
  - Detects and notifies the user of repeated guesses.
  - Congratulates the user upon a correct guess.
- **Guess Tracking**:
  - Records each guess and its exact timestamp.
  - Displays a summary of all guesses and their times after the game ends.
- **Input Validation**: Ensures guesses are valid integers.

---

## **How to Play**

1. Clone the repository:
   ```bash
   git clone https://github.com/manosakpujiha/guessingGame.git

   ## **How to Play**

2. Navigate to the project directory:
   ```bash
   cd guessingGame

3. Run the application:
   ```bash
   dotnet run


4. Guess the hidden number based on the feedback until you find the correct answer!

## **Technologies Used**

- .NET 8
- C#

## **Future Enhancements**

- Add difficulty levels (e.g., Easy, Medium, Hard).
- Implement a scoring system to reward efficient guessing.
- Add a leaderboard to store high scores.

