// Author: Jonathan Spalding
// Assignment: Project 09
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/2/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_9
{
    public partial class Form1 : Form
    {
        // create a Bowling Class Object
        Bowling objectRef;
        // state constants
        const int MAX = 10;
        public Form1()
        {
            InitializeComponent();
            objectRef = new Bowling(MAX);
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProject 9");
        }
        // The inputBox_KeyDown Method
        // Purpose: display the high score, low score and average score
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            // see if the enter key was pressed
            if (e.KeyData == Keys.Enter)
            {
                // if it was, get the data from the text box
                string inputString = inputBox.Text;
                // if there was no string
                if (inputString == "")
                {
                    // set the high score box to show the high score user, and the high score.
                    highScoreBox.Text = ($"{objectRef.GetHighScorePlayer()}: {objectRef.GetHighScore()}");
                    // set the low score box to show the low score user, and the high score.
                    lowScoreBox.Text = ($"{objectRef.GetLowScorePlayer()}: {objectRef.GetLowScore()}");
                    // set the average score box to the average score
                    averageScoreBox.Text = ($"{objectRef.GetAverageScore():f2}");
                }
                else
                {
                    // If a string was entered, then clear the box
                    inputBox.Clear();
                    // send the string to the AddPlayer method in the class to split the string.
                    objectRef.AddPlayer(inputString);
                }
            }
        }
    }
}
