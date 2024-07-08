namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.lblRemainingGuesses = new System.Windows.Forms.Label();
            this.lstScoreboard = new System.Windows.Forms.ListBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(96, 52);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(69, 20);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "lblWord";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.AutoSize = true;
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(99, 100);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(93, 13);
            this.lblIncorrectGuesses.TabIndex = 1;
            this.lblIncorrectGuesses.Text = "Incorrect Guesses";
            // 
            // lblRemainingGuesses
            // 
            this.lblRemainingGuesses.AutoSize = true;
            this.lblRemainingGuesses.Location = new System.Drawing.Point(99, 150);
            this.lblRemainingGuesses.Name = "lblRemainingGuesses";
            this.lblRemainingGuesses.Size = new System.Drawing.Size(101, 13);
            this.lblRemainingGuesses.TabIndex = 2;
            this.lblRemainingGuesses.Text = "Remaining Guesses";
            this.lblRemainingGuesses.Click += new System.EventHandler(this.lblRemainingGuesses_Click);
            // 
            // lstScoreboard
            // 
            this.lstScoreboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstScoreboard.FormattingEnabled = true;
            this.lstScoreboard.Location = new System.Drawing.Point(680, 0);
            this.lstScoreboard.Name = "lstScoreboard";
            this.lstScoreboard.Size = new System.Drawing.Size(120, 450);
            this.lstScoreboard.TabIndex = 3;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(99, 334);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click_1);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(220, 333);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lstScoreboard);
            this.Controls.Add(this.lblRemainingGuesses);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblIncorrectGuesses;
        private System.Windows.Forms.Label lblRemainingGuesses;
        private System.Windows.Forms.ListBox lstScoreboard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnQuit;
    }
}

