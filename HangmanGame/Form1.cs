using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HangmanGame
    {
        public partial class Form1 : Form
        {
            private string[] words = { "HANGMAN", "COMPUTER", "PROGRAMMING", "CSHARP", "VISUALSTUDIO" };
            private string currentWord;
            private string displayWord;
            private ArrayList correctGuesses;
            private ArrayList incorrectGuesses;
            private SortedList scoreboard;
            private int wrongGuesses;
            private Random random;

            public Form1()
            {
                InitializeComponent();
                random = new Random();
                scoreboard = new SortedList();
                InitializeGame();
            }

            private void InitializeGame()
            {
                currentWord = words[random.Next(words.Length)];
                displayWord = new string('_', currentWord.Length);
                correctGuesses = new ArrayList();
                incorrectGuesses = new ArrayList();
                wrongGuesses = 0;

                lblWord.Text = displayWord;
                lblIncorrectGuesses.Text = "Incorrect guesses:";
                lblRemainingGuesses.Text = "Remaining guesses: 10";
                UpdateDisplay();
            }

            private void UpdateDisplay()
            {
                lblWord.Text = displayWord;
                lblIncorrectGuesses.Text = "Incorrect guesses: " + string.Join(", ", incorrectGuesses.ToArray());
                lblRemainingGuesses.Text = $"Remaining guesses: {10 - wrongGuesses}";
            }

            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
            {
                char guess = char.ToUpper(e.KeyChar);

                if (!char.IsLetter(guess) || correctGuesses.Contains(guess) || incorrectGuesses.Contains(guess))
                {
                    return;
                }

                if (currentWord.Contains(guess))
                {
                    correctGuesses.Add(guess);
                    UpdateDisplayWord();
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    wrongGuesses++;
                }

                UpdateDisplay();
                CheckGameStatus();
            }

            private void UpdateDisplayWord()
            {
                char[] newDisplay = displayWord.ToCharArray();
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (correctGuesses.Contains(currentWord[i]))
                    {
                        newDisplay[i] = currentWord[i];
                    }
                }
                displayWord = new string(newDisplay);
            }

            private void CheckGameStatus()
            {
                if (displayWord == currentWord)
                {
                    MessageBox.Show("Congratulations! You've won!");
                    UpdateScoreboard();
                    InitializeGame();
                }
                else if (wrongGuesses >= 10)
                {
                    MessageBox.Show($"Game over! The word was: {currentWord}");
                    UpdateScoreboard();
                    InitializeGame();
                }
            }

            private void UpdateScoreboard()
            {
                int score = correctGuesses.Count + incorrectGuesses.Count;
                if (!scoreboard.ContainsKey(currentWord) || (int)scoreboard[currentWord] > score)
                {
                    scoreboard[currentWord] = score;
                }
                DisplayScoreboard();
            }

            private void DisplayScoreboard()
            {
                lstScoreboard.Items.Clear();
                foreach (DictionaryEntry entry in scoreboard)
                {
                    lstScoreboard.Items.Add($"{entry.Key}: {entry.Value} guesses");
                }
            }

            private void btnNewGame_Click(object sender, EventArgs e)
            {
                InitializeGame();
            }

            private void btnQuit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            InitializeGame();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void lblRemainingGuesses_Click(object sender, EventArgs e)
        {

        }
    }
}


