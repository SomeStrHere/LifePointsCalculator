using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_LifePointsCalculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            //Setup default string for each input box and load upon form load
            string p1DefaultInputStr = "Enter value here...";
            string p2DefaultInputStr = "Enter value here...";

            player1Input.Text = p1DefaultInputStr;
            player2Input.Text = p2DefaultInputStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void player1Score_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(player1Score.Text); //converts contents of text bot to int for this instance???
                    //messageTextBox.Text = "This is a test"; //Testing
                }

                catch
                {
                    // If there is an error, display an error message to the read only message box
                    messageTextBox.Text = "Sorry, there was an error";
                }
            }
        }

        private void player2Score_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(player2Score.Text);
                    messageTextBox.Text = "This is a test"; //Testing
                }

                catch
                {
                    // If there is an error, display an error message to the read only message box
                    messageTextBox.Text = "Sorry, there was an error";
                }
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            

        }

        private void player1Input_TextChanged(object sender, EventArgs e)
        {
           if player1Input == 0 :

        }
    }
}
