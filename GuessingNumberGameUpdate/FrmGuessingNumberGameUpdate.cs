using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingNumberGameUpdate
{
    public partial class FrmGuessingNumberGameUpdate : Form
    {
        public FrmGuessingNumberGameUpdate()
        {
            InitializeComponent();
        }

        Random myRandom = new Random();
        int chosenNumber;
        int actualnumber;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGuessingNumberGameUpdate_Load(object sender, EventArgs e)
        {
            BtnCheckGuess.Enabled = false;
            BtnnumericUpDown1.Enabled = false;
        }

        private void BtnPickShowNumber_Click(object sender, EventArgs e)
        {
            if (BtnPickShowNumber.Text == "Pick Number")
            {
                actualnumber = myRandom.Next(101);
                BtnnumericUpDown1.Enabled = true;
                BtnnumericUpDown1.Value = 50;
                BtnCheckGuess.Enabled = true;
                txtTextBox.Text = "Pick a number between 1 - 100";
                BtnPickShowNumber.Text = "Show Answer";
            }
            else if (BtnPickShowNumber.Text == "Show Answer")
            {
                txtTextBox.Text = "The answer was " + actualnumber;
                BtnnumericUpDown1.Enabled = false;
                BtnPickShowNumber.Text = "Pick Number";
                BtnCheckGuess.Enabled = false;
            }
            {

            }


        }

        private void BtnCheckGuess_Click(object sender, EventArgs e)
        {
            chosenNumber = (int)BtnnumericUpDown1.Value;
            if (chosenNumber == actualnumber) {
                txtTextBox.Text = "Your have chosen the correct answer!";
                BtnnumericUpDown1.Enabled = false;
                BtnPickShowNumber.Text = "Pick Number";
                BtnCheckGuess.Enabled = false;
            }
            else if (chosenNumber > actualnumber)
            {
                txtTextBox.Text = "TOO HIGH";
            }
            else
            {
                txtTextBox.Text = "TOO LOW";
            }
        }

        private void BtnnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
