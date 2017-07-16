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
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void player1Score_TextChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    int.Parse(player1Score.Text);          
                }

                catch
                {
                    // If there is an error, display error message
                    //errorTextBox.Text = "Sorry, there was an error";
                }
            }
        }

        private void player2Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
