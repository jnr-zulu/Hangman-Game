# Hangman Game

A classic Hangman game implemented in C# using Windows Forms.

## Description

This project is a simple implementation of the Hangman word-guessing game. It features a graphical user interface built with Windows Forms, allowing players to guess letters and try to uncover a hidden word before running out of attempts.

## Features

- Randomly selected words from a predefined list
- Visual representation of the word being guessed
- Tracking of correct and incorrect guesses
- Limited number of incorrect guesses (10) before game over
- Scoreboard to keep track of best scores for each word
- Options to start a new game or quit

## Requirements

- Visual Studio (preferably 2019 or later)
- .NET Framework 4.7.2 or higher

## How to Run

1. Clone this repository to your local machine.
2. Open the solution file (`HangmanGame.sln`) in Visual Studio.
3. Build the solution by going to `Build > Build Solution` in the menu.
4. Run the game by pressing `F5` or clicking the "Start" button in Visual Studio.

## How to Play

1. The game starts with a hidden word represented by underscores.
2. Type letters on your keyboard to guess.
3. Correct guesses will reveal the letter in the word.
4. Incorrect guesses will be added to the "Incorrect guesses" list.
5. You have 10 incorrect guesses before the game ends.
6. Try to guess the entire word before running out of attempts!

## Future Improvements

- Add more words to the game's dictionary
- Implement difficulty levels
- Add visual representation of the hangman figure
- Include sound effects and animations
- Create a custom word list input feature

## Contributing

Contributions to improve the game are welcome. Please feel free to fork the repository and submit pull requests.
