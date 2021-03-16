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
        int guesses = 0;
        int difficulty = 0; // 0 = Easy
        string guess = "";
        string chosen = "";
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
            lblWord.Text = "__ __ __ __ __";
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
            lstLetters.DataSource = words;
            chosen = words[generator.Next(23)];
            lblTitle.Text = chosen;
            txtInput.Visible = true;
            btnGuess.Visible = true;

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtInput.Text.ToUpper();
            if (chosen.IndexOf(guess) >= 0)
            {
                chosen.Remove(chosen.IndexOf(guess));
                guessedletters.Add(guess);
                if (chosen.IndexOf(guess) == 0)
                {
                    if 
                    lblWord.Text = (guess + " __ __ __ __");
                }
                lstLetters.DataSource = null;
                lstLetters.DataSource = words;
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
