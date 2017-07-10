using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        private string word = "This is Hangman";
        private List<char> currentGuesses = new List<char>();
        private string placeHolder = "";
        private Shape[] bodyShapes;
        private int currentShape;
        private int numberGuessed;

        public frmHangman()
        {
            InitializeComponent();
            bodyShapes = new Shape[] { shpHead, shpBody, shpLeftArm, shpRightArm, shpLeftLeg, shpRightLeg };
            setupNewGame();
        }

        private void setupNewGame()
        {
            //Randomly select a word from a dictionary API eventually?

            StringBuilder sb = new StringBuilder();
            string[] wordOptions = word.ToLower().Split(' ');
            for (int i = 0; i < wordOptions.Length; i++)
            {
                for (int j = 0; j < wordOptions[i].Length; j++)
                {
                    sb.Append("_ ");
                }
                sb.Append("  ");
            }
            placeHolder = sb.ToString();
            lblWordGap.Text = placeHolder;
            btnGuess.Enabled = true;
        }

        private void clearCurrentGame()
        {
            //hide body shapes.
            foreach (Shape s in bodyShapes)
            {
                s.Visible = false;
            }
            currentShape = 0;
            currentGuesses = new List<char>();

            //clear guesses
            lblWrongGuesses.Text = "";
            lblWordGap.Text = "";
        }

        private void showNextBodyShape()
        {
            bodyShapes[currentShape].Visible = true;
            currentShape++;
            if (currentShape == bodyShapes.Length)
                endGame(false);
        }

        //Converts the index in the actual word to the index in space separated text.
        private int convertToGap(int x)
        {
            return x * 2;
        }

        private string processGuess(char guess)
        {
            var correct = false;
            char[] phWithGuess = placeHolder.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word.ToUpper().ToCharArray()[i] == guess)
                {
                    phWithGuess[convertToGap(i)] = guess;
                    correct = true;
                    numberGuessed++;
                }
            }

            if (!phWithGuess.Contains('_'))
            {
                endGame(true);
            }

            //Inform the user if they are correct.
            (new System.Threading.Thread(CloseMessageBox)).Start();
            if (correct) lblWordGap.Text = lblWordGap.Text;
            else
            {
                showNextBodyShape();
                lblWrongGuesses.Text = lblWrongGuesses.Text + " " + guess;
            }

            currentGuesses.Add(guess);
            return new string(phWithGuess);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearCurrentGame();
            setupNewGame();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToUpper();
            txtGuess.Text = "";
            txtGuess.Focus();

            if (guess.Length != 1 || !guess.All(Char.IsLetter)) {
                MessageBox.Show("You must enter exactly one letter in the textbox.");
                return;
            }
            if (currentGuesses.Contains(guess.ToCharArray()[0]))
            {
                MessageBox.Show("You already tried that one.");
                return;
            }

            placeHolder = processGuess(Convert.ToChar(guess));
            lblWordGap.Text = placeHolder;
        }

        public void CloseMessageBox()
        {
            
        }

        private void endGame(bool win)
        {
            btnGuess.Enabled = false;
            if (win)
                MessageBox.Show("Congratulations, you won.");
            else
                MessageBox.Show("You've been hung!\nYou're word was " + word);
        }

        private void closeWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
