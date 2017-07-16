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
        int p1DefaultInput; // declare variables here to allow access from click events
        int p2DefaultInput;
        
        public mainForm()
        {
            InitializeComponent();

            p1DefaultInput = 0;
            p2DefaultInput = 0;

            player1Input.Text = p1DefaultInput.ToString(); // assign the default input value back as string
            player2Input.Text = p2DefaultInput.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int intPlayer1Input = int.Parse(player1Input.Text); // create int variables for each player representing score and input value
            int intPlayer1Score = int.Parse(player1Score.Text);  

            int intPlayer2Input = int.Parse(player2Input.Text); 
            int intPlayer2Score = int.Parse(player2Score.Text);

            if  (intPlayer1Input != p1DefaultInput)
            {
                intPlayer1Score = intPlayer1Score + intPlayer1Input; //perform the addition
                player1Score.Text = intPlayer1Score.ToString(); //assign the converted int back to the text property  of player1Score
                player1Input.Text = p1DefaultInput.ToString(); //after the addition operation reset the input text box to 0
            }

            if (intPlayer2Input != p2DefaultInput)
            {

                intPlayer2Score = intPlayer2Score + intPlayer2Input; //perform the addition
                player2Score.Text = intPlayer2Score.ToString();
                player2Input.Text = p2DefaultInput.ToString(); //after the addition operation reset the input text box to 0

            }

        }

        private void player1Score_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(player1Score.Text); //converts contents of text bot to int for this instance???
                    messageTextBox.Text = "Player 1 score updated";
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
                    messageTextBox.Text = "Player 2 score updated";
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
            //if (player1Input.Text == "0")
            //    player1Input.Text = p1DefaultInputStr;

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int intPlayer1Input = int.Parse(player1Input.Text); // create int variables for each player representing score and input value
            int intPlayer1Score = int.Parse(player1Score.Text);

            int intPlayer2Input = int.Parse(player2Input.Text);
            int intPlayer2Score = int.Parse(player2Score.Text);

            if (intPlayer1Input != p1DefaultInput)
            {
                intPlayer1Score = intPlayer1Score - intPlayer1Input; //perform the subtraction
                player1Score.Text = intPlayer1Score.ToString(); //assign the converted int back to the text property  of player1Score
                player1Input.Text = p1DefaultInput.ToString(); //after the subtract operation reset the input text box to 0
            }

            if (intPlayer2Input != p2DefaultInput)
            {

                intPlayer2Score = intPlayer2Score - intPlayer2Input; //perform the subtraction
                player2Score.Text = intPlayer2Score.ToString();
                player2Input.Text = p2DefaultInput.ToString(); //after the subtraction operation reset the input text box to 0

            }
        }
    }
}
