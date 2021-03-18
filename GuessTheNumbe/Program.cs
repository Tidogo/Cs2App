//      ----Change History for GuessTheNumber by Timothy Goddard----
// Date               Author                       Description
// 2/6/2021           Timothy Goddard              Initial creation with full functionality
// 2/6/2021           Timothy Goddard              Comments added

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    // this class contains all the code for the GuessTheNumber project
    class Program
    {
        // this main method will play a guessing game with the user with random int
        // between 1 and 1000
        static void Main(string[] args)
        {
            // create variables for later use
            Random rand = new Random();
            bool correctGuess = false;
            int userGuess = 0;
            bool keepPlaying = true;
            string yesOrNo = string.Empty;

            // display instructions to user
            Console.WriteLine("This program is a guessing game. The computer will pick a" +
                " random number between 1 and 1000 and you will have to guess the number." +
                " To help, the computer will tell you if your guess is too high or too low.");
            // outer while loop ensures that user can continue playing if they want to
            while (keepPlaying == true)
            {
                // each iteration of the 'game' while loop will create new rand int for guessing
                int computerNum = rand.Next(1, 1000);
                correctGuess = false;

                // inner while loop will continue if user has not guessed correctly
                while (correctGuess == false)
                {
                    Console.Write("Guess a number between 1 and 1000: ");
                    userGuess = int.Parse(Console.ReadLine());

                    // if correct guess, congratulate user and break out of while loop
                    if (userGuess == computerNum)
                    {
                        correctGuess = true;
                        Console.WriteLine("Congratulations. You guessed the number!");
                    }

                    // if too high, inform user so they can guess more accurately next iteration
                    else if (userGuess > computerNum)
                    {
                        Console.WriteLine("Too high. Try again.");
                    }

                    // if too low, inform and iterate
                    else
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                }
                // once user has guess correctly, ask them if they want to play again
                Console.Write("Would you like to play again? y for yes, n for no: ");
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }
            }
        }
    }
}
