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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    class Bowling
    {
        // state constants
        const int MAX = 10;
        const int MIN = 0;
        // state other variables and data members
        private int numberOfPlayers = 0;
        private int highScore = 0;
        private int lowScore = 0;
        private int highScorePlayer = 0;
        private int lowScorePlayer = 0;
        private double sum = 0;
        private double quotient;
        // create an array for the user input.
        private string[] names;
        private int[] scores;
        // The default constructor
        // Purpose: It sets all declared variables (data members of the class) to what they need to be.
        // Parameters:
        // Returns: None
        public Bowling(int MAX)
        {
            // set both arrays to the length of 10
            names = new string[MAX];
            scores = new int[MAX];
        }
        // The GetHighScorePlayer method
        // Purpose: To find the high score player in the scores array, and return that user.
        // Parameters: None
        // Returns: string names[highScorePlayer]
        public string GetHighScorePlayer()
        {
            // for loop that runs the ammount of times there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // if statement to find the highest score
                if (scores[i] > scores[highScorePlayer])
                    highScorePlayer = i;
            }
            // return the highest scored player.
            return names[highScorePlayer];
        }
        // The GetHighScore method
        // Purpose: To find the highScore in the scores array, and return that user.
        // Parameters: None
        // Returns: string scores[highScore]
        public int GetHighScore()
        {
            // for loop that runs the ammount of times there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // if statement to find the highest score and assign it to the highScore variable.
                if (scores[i] > scores[highScore])
                    highScore = i;
            }
            // return the highest score.
            return scores[highScore];
        }
        // The GetLowScorePlayer method
        // Purpose: To find the low score player in the scores array, and return that user.
        // Parameters: None
        // Returns: string names[lowScorePlayer]
        public string GetLowScorePlayer()
        {
            // for loop that runs the number of times there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // if statemet that finds the player with the lowest score
                if (scores[i] < scores[lowScorePlayer])
                    lowScorePlayer = i;
            }
            // returns the name of the lowest scored player
            return names[lowScorePlayer];
        }
        // The GetLowScore method
        // Purpose: To find the LowScore in the scores array, and return that user.
        // Parameters: None
        // Returns: string scores[LowScore]
        public int GetLowScore()
        {
            // for loop that runs the number of times that there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // if statement that finds the lowest score in the scores array.
                if (scores[i] < scores[lowScore])
                    lowScore = i;
            }
            // returns the lowest score in the scores array.
            return scores[lowScore];
        }
        // The GetAverageScore method
        // Purpose: To add all the scores together, then divide it by the number of players
        // Parameters: None
        // Returns: double quotient
        public double GetAverageScore()
        {
            // for loop that runs the number of times that there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // add each user's score together.
                sum = sum + (double)scores[i];
            }
            // divide the total by the number of players to find the average.
            quotient = sum / (double)numberOfPlayers;
            // return the average.
            return quotient;
        }
        // The AddPlayer method
        // Purpose: split the users from the scores, assign them to the appropriate arrays, and the add one more player.
        // Parameters: string userInput
        // Returns: none
        public void AddPlayer(string userInput)
        {
            // userInput is split into two pieces, which are stored in this array of strings
            string[] parsedInput;
            // this line splits the string userInput into the two pieces
            parsedInput = userInput.Split();
            // store the first piece, the name, in a string variable
            names[numberOfPlayers] = parsedInput[0];
            // store the second piece, a score, in an integer variable
            scores[numberOfPlayers] = int.Parse(parsedInput[1]);
            // add another player to the "numberOfPlayers"
            ++numberOfPlayers;
        }
    }
}