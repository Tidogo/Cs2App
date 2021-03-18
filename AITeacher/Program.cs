//      ----Change History for AITeacher by Timothy Goddard----
// Date               Author                       Description
// 2/6/2021           Timothy Goddard              Initial creation with full functionality
// 2/6/2021           Timothy Goddard              Comments added

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITeacher
{
    // this class contains all the code for AITeacher
    class Program
    {
        // this main method goes through the process of asking multiplication questions
        // to the user.
        static void Main(string[] args)
        {
            // this block of code instructs the user on the purpose of the program 
            // and calls the questionmaker method to start the question process.
            Console.WriteLine("This is a program that will test your multiplication skills." +
                " You will be asked simple multiplication problems with two single digit integers");
            bool play = QuestionMaker();

            // because questionmaker returns a bool, using the bool to determine when user
            // wants to stop.
            while (play == true)
            {
                play = QuestionMaker();
            }
            Console.WriteLine("Please enter any key to exit");
            Console.ReadLine();
        }

        // this method creates multiplication questions for the user and prompts them
        // to solve the problems. Will loop until user guesses correctly. Returns bool val.
        public static bool QuestionMaker()
        {
            // create variables to be used later
            Random rand = new Random();
            int intOne = rand.Next(1, 9);
            int intTwo = rand.Next(1, 9);
            int correctGuess = intOne * intTwo;
            int userGuess = 0;
            bool keepPlaying = false;
            int userContinue = 0;

            // will keep looping until user correctly calculates the solution
            while (userGuess != correctGuess)
            {
                Console.WriteLine("How much is " + intOne + " times " + intTwo + "?");
                userGuess = int.Parse(Console.ReadLine());

                // if statement for if user gets it right, will break out of while loop
                if (userGuess == correctGuess)
                {
                    Console.WriteLine("Very good!");
                    Console.WriteLine("Would you like to continue? 1 for yes, 0 for no");
                    userContinue = int.Parse(Console.ReadLine());
                    if (userContinue == 1)
                    {
                        keepPlaying = true;
                    }
                    else
                    {
                        keepPlaying = false;
                    }
                }
                else
                {
                    Console.WriteLine("No. Please try again.");
                }
            }
            return keepPlaying;
        }
    }
}
