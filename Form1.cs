﻿using System;
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
        bool buttonmove = false;
        bool redup = false;
        int guesses = 0;
        int difficulty = 0; // 0 = Easy
        int placement;
        int redvalue = 192;
        int buttoncounter = 4;
        string guess;
        string chosenword = "";
        string emptyslot = "__ ";
        System.IO.Stream str;
        System.Media.SoundPlayer snd;
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
            str = Properties.Resources.Fixed_Stage_1;
            snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
            this.BackColor = Color.FromArgb(0, 192, 0);
            feedback.Clear();
            words.Clear();
            guessedletters.Clear();
            for (int i = 0; i <= 4; i++)
                feedback.Add(emptyslot);
            //lstLetters.DataSource = feedback;
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
            chosenword = words[generator.Next(22)];
            //lblTitle.Text = chosenword;
            guesses = 3;
            buttoncounter = 4;
            lblCounter.Text = ("Guesses remaining : " + guesses);
            imgHang.Image = Properties.Resources.hangman_empty;
            txtInput.Visible = true;
            btnGuess.Visible = true;
            btnEasy.Visible = false;
            btnNormal.Visible = false;
            btnHard.Visible = false;
            buttonmove = false;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtInput.Text.ToUpper();
            if (chosenword.IndexOf(guess) >= 0)
            {
                if (buttoncounter == 0)
                    buttoncounter += 4;
                while (chosenword.IndexOf(guess) != -1 )
                {
                    placement = chosenword.IndexOf(guess);
                    //chosenword = chosenword.Replace(guess, "1");
                    chosenword = chosenword.Remove(placement, 1);
                    chosenword = chosenword.Insert(placement, "1");


                //    //chosenword.Remove(chosenword.IndexOf(guess));
                //    System.Text.StringBuilder firstbuilder = new System.Text.StringBuilder(chosenword);
                //    System.Text.StringBuilder secondbuilder = new System.Text.StringBuilder(modifiedword);
                //    if (i == 0)
                //    {
                //        firstbuilder[placement] = Convert.ToChar("1");
                //        modifiedword = firstbuilder.ToString();
                //    }
                //    else
                //    {
                //        secondbuilder[placement] = Convert.ToChar("1");
                //        modifiedword = secondbuilder.ToString();
                //    }
                //lblInstructions.Text = chosenword;
                feedback.RemoveAt(placement);
                feedback.Insert(placement, guess);
                //}
                lblWord.Text = string.Join("", feedback);
                
                }
                guessedletters.Add(guess);
                lstLetters.DataSource = null;
                lstLetters.DataSource = guessedletters;
                if (chosenword == "11111" || chosenword == "1111111" || chosenword == "111111111")
                {
                    lblCounter.Text = "You win!";
                    btnGuess.Enabled = false;
                    btnGuess.Text = "Guess";
                    btnGuess.Location = new Point(630, 364);
                    btnEasy.Visible = true;
                    btnNormal.Visible = true;
                    btnHard.Visible = true;
                    tmrColour.Enabled = false;
                }

            }
            else
            {
                guessedletters.Add(guess);
                lstLetters.DataSource = null;
                lstLetters.DataSource = guessedletters;
                guesses -= 1;
                lblCounter.Text = ("Guesses remaining : " + guesses);
                if (guesses == 2)
                {
                    imgHang.Image = Properties.Resources.hangman_1;
                    this.BackColor = Color.FromArgb(192, 192, 0);
                }
                else if (guesses == 1)
                {
                    imgHang.Image = Properties.Resources.hangman_2;

                    this.BackColor = Color.FromArgb(192, 50, 50);
                    buttonmove = true;
                    tmrColour.Enabled = true;
                }
                    
                else
                {
                    imgHang.Image = Properties.Resources.hangman_empty;
                    lblCounter.Text = "You lost!";
                    btnGuess.Enabled = false;
                    btnGuess.Text = "Guess";
                    btnGuess.Location = new Point(630, 364);
                    btnEasy.Visible = true;
                    btnNormal.Visible = true;
                    btnHard.Visible = true;
                    tmrColour.Enabled = false;
                }    
            }
            txtInput.Clear();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 1 || guessedletters.Contains(txtInput.Text.ToUpper()))
                btnGuess.Enabled = false;
            else
                btnGuess.Enabled = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 192, 0);
            feedback.Clear();
            words.Clear();
            guessedletters.Clear();
            for (int i = 0; i <= 6; i++)
                feedback.Add(emptyslot);
            //lstLetters.DataSource = feedback;
            lblWord.Text = string.Join("", feedback);
            //lblWord.Text = emptyslot + emptyslot + emptyslot + emptyslot+ emptyslot;
            words.Add("MAXIMUM");
            words.Add("PICKAXE");
            words.Add("BOOMBOX");
            words.Add("JELLIFY");
            words.Add("LIQUIFY");
            words.Add("JACKPOT");
            words.Add("HAMMOCK");
            words.Add("GRIZZLY");
            words.Add("FLUXING");
            words.Add("HAMMOCK");
            words.Add("OXIDIZE");
            words.Add("JUSTIFY");
            words.Add("HYPOXIA");
            words.Add("JUJITSU");
            words.Add("KNUCKLE");
            words.Add("OBLIQUE");
            words.Add("CROQUET");
            words.Add("ZOMBIFY");
            words.Add("ZYGOTIC");
            words.Add("QUICKLY");
            words.Add("PREDICT");
            words.Add("TWIZZLE");
            //lstLetters.DataSource = words;
            chosenword = words[generator.Next(22)];
            //lblTitle.Text = chosenword;
            guesses = 3;
            buttoncounter = 4;
            lblCounter.Text = ("Guesses remaining : " + guesses);
            imgHang.Image = Properties.Resources.hangman_empty;
            txtInput.Visible = true;
            btnGuess.Visible = true;
            btnEasy.Visible = false;
            btnNormal.Visible = false;
            btnHard.Visible = false;
            buttonmove = false;
        }

        private void btnGuess_MouseHover(object sender, EventArgs e)
        {
            if (buttonmove == true && buttoncounter != 0)
            {
                btnGuess.Location = new Point(generator.Next(700), generator.Next(300));
                buttoncounter -= 1;
                if (buttoncounter == 3)
                    btnGuess.Text = "You sure?";
                else if (buttoncounter == 2)
                    btnGuess.Text = "Super sure?";
                else if (buttoncounter == 1)
                    btnGuess.Text = "Super duper sure?";
                else
                    btnGuess.Text = "Time to decide!";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (redup == false && this.BackColor != Color.FromArgb(100, 50, 50))
            {
                redvalue -= 1;
                this.BackColor = Color.FromArgb(redvalue, 50, 50);
                //lblUsedLetters.Text = Convert.ToString(redvalue);
            }
            else if (this.BackColor == Color.FromArgb(100, 50, 50))
            {
                redup = true;
                redvalue += 1;
                this.BackColor = Color.FromArgb(redvalue, 50, 50);

            }
            else if (redup == true && this.BackColor != Color.FromArgb(192, 50, 50))
            {
                redvalue += 1;
                this.BackColor = Color.FromArgb(redvalue, 50, 50);
                //lblUsedLetters.Text = Convert.ToString(redvalue);
            }
            else if (this.BackColor == Color.FromArgb(192, 50, 50))
            {
                redup = false;
                redvalue -= 1;
                this.BackColor = Color.FromArgb(redvalue, 50, 50);
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 192, 0);
            feedback.Clear();
            words.Clear();
            guessedletters.Clear();
            for (int i = 0; i <= 8; i++)
                feedback.Add(emptyslot);
            //lstLetters.DataSource = feedback;
            lblWord.Text = string.Join("", feedback);
            //lblWord.Text = emptyslot + emptyslot + emptyslot + emptyslot+ emptyslot;
            words.Add("BRAINLESS");
            words.Add("WITHERING");
            words.Add("SOPHOMORE");
            words.Add("XYLOPHONE");
            words.Add("LOUISIANA");
            words.Add("TURQUOISE");
            words.Add("WHIMSICAL");
            words.Add("DIFFICULT");
            words.Add("SPAGHETTI");
            words.Add("AMENDMENT");
            words.Add("CARIBBEAN");
            words.Add("DIVERGENT");
            words.Add("SCHNITZEL");
            words.Add("SCORCHING");
            words.Add("CHAMELEON");
            words.Add("BRILLIANT");
            words.Add("SANCTUARY");
            words.Add("PENINSULA");
            words.Add("MECHANISM");
            words.Add("MARGARITA");
            words.Add("FRIVOLOUS");
            words.Add("METRONOME");
            //lstLetters.DataSource = words;
            chosenword = words[generator.Next(22)];
            //lblTitle.Text = chosenword;
            guesses = 3;
            buttoncounter = 4;
            lblCounter.Text = ("Guesses remaining : " + guesses);
            imgHang.Image = Properties.Resources.hangman_empty;
            txtInput.Visible = true;
            btnGuess.Visible = true;
            btnEasy.Visible = false;
            btnNormal.Visible = false;
            btnHard.Visible = false;
            buttonmove = false;
        }

    }
}
