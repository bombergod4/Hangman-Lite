namespace Hangman_Lite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.lstLetters = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.tmrColour = new System.Windows.Forms.Timer(this.components);
            this.tmrFlicker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Hangman";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(27, 75);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(308, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter a letter to reveal the hidden word. 4 strikes and you\'re out!";
            // 
            // imgHang
            // 
            this.imgHang.Location = new System.Drawing.Point(30, 91);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(281, 250);
            this.imgHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHang.TabIndex = 2;
            this.imgHang.TabStop = false;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(502, 44);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(142, 29);
            this.lblUsedLetters.TabIndex = 3;
            this.lblUsedLetters.Text = "Used Letters";
            // 
            // lstLetters
            // 
            this.lstLetters.FormattingEnabled = true;
            this.lstLetters.Location = new System.Drawing.Point(507, 77);
            this.lstLetters.Name = "lstLetters";
            this.lstLetters.Size = new System.Drawing.Size(205, 264);
            this.lstLetters.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(507, 364);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 5;
            this.txtInput.Visible = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSize = true;
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(630, 364);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(67, 23);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Visible = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            this.btnGuess.MouseHover += new System.EventHandler(this.btnGuess_MouseHover);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Red;
            this.btnHard.Location = new System.Drawing.Point(367, 108);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(108, 41);
            this.btnHard.TabIndex = 7;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Yellow;
            this.btnNormal.Location = new System.Drawing.Point(367, 61);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(108, 41);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Lime;
            this.btnEasy.Location = new System.Drawing.Point(367, 12);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(108, 41);
            this.btnEasy.TabIndex = 9;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblWord.Location = new System.Drawing.Point(12, 394);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(501, 47);
            this.lblWord.TabIndex = 10;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(30, 357);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(305, 27);
            this.lblCounter.TabIndex = 11;
            this.lblCounter.Text = "Guesses remaining : 3";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrColour
            // 
            this.tmrColour.Interval = 50;
            this.tmrColour.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrFlicker
            // 
            this.tmrFlicker.Interval = 25;
            this.tmrFlicker.Tick += new System.EventHandler(this.tmrFlicker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstLetters);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.imgHang);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.ListBox lstLetters;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer tmrColour;
        private System.Windows.Forms.Timer tmrFlicker;
    }
}

