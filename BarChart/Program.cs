//      ----Change History for BarChart by Timothy Goddard----
// Date               Author                       Description
// 2/6/2021           Timothy Goddard              Initial creation with full functionality
// 2/6/2021           Timothy Goddard              Comments added

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    // this class contains all code for the BarChart project
    class Program
    {
        // this main method will inform user of the programs functionality and then follow through
        // on the functionality.
        static void Main(string[] args)
        {
            // local variables for while loop
            int count = 1;
            bool parse = true;
            // inform user of program functionality
            Console.WriteLine("This program will take 3 numbers between 1-30 and print" +
                " that amount of asterisks in return. If you want to exit before entering" +
                " all three numbers, enter anything but a number and the program will abort.");

            // this while loop is a bit complicated but it essentially ensures that the
            // user can exit at any time if the user enters anything but an integer.
            while (count <= 3 && parse == true) {
                Console.Write($"Please enter the whole number {count}: ");
                int flag;
                // store the user input in a temp string to check if it can be parsed
                string temp = Console.ReadLine();
                // if temp can be succcessfully parsed, perform operation and continue
                if (int.TryParse(temp, out flag) == true)
                {
                    int userNum = int.Parse(temp);
                    Console.WriteLine($"Here is the asterisk equivalent for number {count}: " 
                        + PrintAsterisks(userNum));
                }
                // if user entered anything that isn't an int, exit
                else
                {
                    parse = false;
                }
                count++;
            }
            // prompt user to exit
            Console.WriteLine("Please enter any key to exit");
            Console.ReadLine();
        }

        // this method performs the act of creating an equivalent asterisk string
        // with the same length as the number it takes. Returns string.
        public static string PrintAsterisks(int num)
        {
            string asterisks = string.Empty;
            for (int i = 0; i < num; i++)
            {
                asterisks += "*";  
            }
            return asterisks;
        }
    }
}
