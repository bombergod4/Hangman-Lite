using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Lite
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        List<string> words = new List<string>();
        List<string> guessedletters = new List<string>();
        List<string> feedback = new List<string>();
        int guesses = 0;
        int difficulty = 0; // 0 = Easy
        int placement;
        string guess;
        string chosenword = "";
        string modifiedword;
        string emptyslot = "__ ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuess.Enabled = false;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            feedback.Clear();
            for (int i = 0; i <= 4; i++)
                feedback.Add(emptyslot);
            lstLetters.DataSource = feedback;
            lblWord.Text = string.Join("", feedback);
            //lblWord.Text = emptyslot + emptyslot + emptyslot + emptyslot+ emptyslot;
            words.Add("CHINA");
            words.Add("SCALE");
            words.Add("JOKER");
            words.Add("ROYAL");
            words.Add("TRASH");
            words.Add("CHALK");
            words.Add("ENTER");
            words.Add("GIANT");
            words.Add("FLOCK");
            words.Add("APPLE");
            words.Add("BELLY");
            words.Add("HEAVY");
            words.Add("INTEL");
            words.Add("JUICE");
            words.Add("KNOWN");
            words.Add("LOSER");
            words.Add("METAL");
            words.Add("OPERA");
            words.Add("RALLY");
            words.Add("QUEUE");
            words.Add("PAINT");
            words.Add("TABLE");
            //lstLetters.DataSource = words;
            chosenword = words[generator.Next(23)];
            lblTitle.Text = chosenword;
            txtInput.Visible = true;
            btnGuess.Visible = true;

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtInput.Text.ToUpper();
            if (chosenword.IndexOf(guess) >= 0)
            {
                for (int i = 0; i <= 5; i++)
                {
                    placement = chosenword.IndexOf(guess);
                    //chosenword.Remove(chosenword.IndexOf(guess));
                    System.Text.StringBuilder firstbuilder = new System.Text.StringBuilder(chosenword);
                    System.Text.StringBuilder secondbuilder = new System.Text.StringBuilder(modifiedword);
                    if (i == 0)
                    {
                        firstbuilder[placement] = Convert.ToChar("1");
                        modifiedword = firstbuilder.ToString();
                    }
                    else
                    {
                        secondbuilder[placement] = Convert.ToChar("1");
                        modifiedword = secondbuilder.ToString();
                    }
                    lblInstructions.Text = modifiedword;
                    feedback.RemoveAt(placement);
                    feedback.Insert(placement, guess);
                }
                lblWord.Text = string.Join("", feedback);
                guessedletters.Add(guess);
                //if (chosenword.IndexOf(guess) == 0)
                //{
                //    //if   
                //    //lblWord.Text = (guess + " __ __ __ __");
                //}
            }
            else
            {
                guessedletters.Add(guess);
                lstLetters.DataSource = null;
                lstLetters.DataSource = guessedletters;
                guesses += 1;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 1)
                btnGuess.Enabled = false;
            else
                btnGuess.Enabled = true;
        }
    }
}
