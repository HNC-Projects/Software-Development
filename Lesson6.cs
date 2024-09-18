/* Lesson 6 Class
 * Jayden Wilson
 * 18 Sep 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Software_Development
{
    public static class Lesson6
    {
        /// <summary>
        /// Task 1
        /// A method that is used to show the 
        /// values from shortcut operations
        /// </summary>
        public static void ShortcutOperations()
        {
            int x = 12;
            int y = 4;
            int z;

            z = x; //Value of z is 12
            Console.WriteLine(z);

            x = z + 4; //Value of x is 16
            Console.WriteLine(x);

            x++; //Adds 1 to x (16 + 1 = 17)
            Console.WriteLine(x);

            y += 2; //Adds 2 to the current value of y (4 + 2 = 6)
            Console.WriteLine(y);

            x -= 3; //Subtracts 3 to the current value of x (17 - 3 = 14)
            Console.WriteLine(x);

            y--; //Subtracts 1 from y (6 - 1 = 5)
            Console.WriteLine(y);

            y = y * 2 + 3; //Multiplies y by 2 then adds 3 ( 5 x 2 = 10 --> 10 + 3 = 13) 
            Console.WriteLine(y);

            z = ++y; //Adds 1 to y and stores it in z. Must add ++ before y as y is not being used.
            Console.WriteLine(z);
        }

        /// <summary>
        /// Task 2
        /// A method that is used to print 1 to 15
        /// </summary>
        public static void SimpleLoop()
        {
            //Loop that prints 5 to 15 
            for(int number = 5; number <= 15; number++)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Task 3
        /// A method that is used to print the 
        /// times table specified 
        /// </summary>
        public static void TimesTable()
        {
            Console.Write("What do you want the base number to be? ");

            //Ask user of a base number 
            int baseNumber = int.Parse(Console.ReadLine());

            //Loop that prints the times table from 1 to 12 for the base number
            for(int number = 1; number <= 12; number++)
            {
                int result = number * baseNumber;
                Console.WriteLine($"{number} x {baseNumber} = {result}");
            }
        }

        /// <summary>
        /// Challenge 1
        /// A method that is used to countdown from 10 to 1
        /// </summary>
        public static void Countdown()
        {
            //Loop that prints a countdown from 10 to 1 
            for(int number = 10; number > 0; number--)
            {
                Console.Beep(); //Makes a beep sound
                Console.WriteLine(number);

                //1 Second Delay
                Thread.Sleep(1000);
            }

            Console.WriteLine("Blast Off!!!!");

        }
            
        /// <summary>
        /// Task 4
        /// A Method that is used to display 
        /// even numbers.
        /// </summary>
        public static void EvenNumbers()
        {
            int count = 10; //Determines if the rest of the values will be odd or even

            //Checks if the count is less than 24. Loops until true
            while (count < 24)
            {
                Console.WriteLine(count);
                count += 2; //Adds 2 to the current count (10 + 2 = 12 which is an even number) Every 2nd number
            }
        }

        /// <summary>
        /// Challenge 2
        /// A method that is used to print the 
        /// times table specified with additional 
        /// inputs and conditions.
        /// </summary>
        public static void TimesTableExtended()
        {
            do
            {
                Console.Write("What do you want the base number to be? Enter 999 to stop: ");

                //Ask user of a base number 
                int baseNumber = int.Parse(Console.ReadLine());

                //Check if number entered is 99
                if (baseNumber == 999)
                {
                    Console.WriteLine("Stopped Application");
                    break; //Breaks out of the loop
                }

                //Loop that prints the times table from 1 to 12 for the base number
                for (int number = 1; number <= 12; number++) //Includes 1 and 12 
                {
                    int result = number * baseNumber;
                    Console.WriteLine($"{number} x {baseNumber} = {result}");
                }
            }
            while (true);
        }

        /// <summary>
        /// Exercise 6.1
        /// A Method that is used to display 
        /// odd numbers.
        /// </summary>
        public static void OddNumbers()
        {
             int count = 1; //Determines if the rest of the values will be odd or even

            //Checks if the count is less than 24. Loops until true
            while (count < 99)
            {
                Console.WriteLine(count);
                count += 2; //Adds 2 to the current count (1 + 2 = 3 which is an odd number). Every 2nd number
            }
        }

        /// <summary>
        /// Exercise 6.2
        /// A Method that is used to display 
        /// even numbers in reverse order.
        /// </summary>
        public static void EvenNumbersReversed()
        {
            //A loop that starts from 100and ends at 1. Displaying the even numbers
            for (int i = 100; i >= 2; i-=2)
            {
                Console.WriteLine(i);
            }

            //int count = 100;
            //while (count > 0)
            //{
            //    Console.WriteLine(count);
            //    count -= 2;
            //}
        }

        /// <summary>
        /// Exercise 6.3
        /// A method that is used to find the total 
        /// amount of a's in a string.
        /// </summary>
        public static void Letters()
        {
            Console.Write("Enter Text: ");
            string text = Console.ReadLine();

            int total = 0;
            int length = text.Length; //Gets number of characters in the string

            for (int i = 1; i < length; i++)
            {
                //Sets character to that of the current character in the string using the index (i) 
                char character = text[i];

                //Add 1 to the total if the character is "a"
                if (character == 'a')
                {
                    total++;
                }
            }

            Console.WriteLine($"The Text \"{text}\" contains {total} a's");
        }

        /// <summary>
        /// Exercise 6.4
        /// A method that is used to see if an entered number 
        /// is odd or even. Displays total odd and even numbers 
        /// when stopped.
        /// </summary>
        public static void OddEven()
        {
            int oddTotal = 0;
            int evenTotal = 0;

            do
            {
                //Asks user to enter a number or type STOP
                Console.Write("Enter a number or type: STOP: ");
                string input = Console.ReadLine();

                if (!input.Equals("STOP", StringComparison.OrdinalIgnoreCase)) 
                //if(input.Equals("STOP", StringComparison.OrdinalIgnoreCase) == false)
                {
                    //Checks if the number give a remainder when divided by 2
                    if(int.Parse(input) % 2 >= 1)
                    {
                        Console.WriteLine($"{input} is an odd number\n");
                        oddTotal++; //Add 1 to oddTotal
                    }
                    else
                    {
                        Console.WriteLine($"{input} is an even number\n");
                        evenTotal++;//Add 1 to evenTotal
                    }
                }
                else
                {
                    //Displays both totals to console
                    Console.WriteLine($"You entered {oddTotal} odd and {evenTotal} even numbers");
                    break;
                }
            }
            while (true);
        }

        /// <summary>
        /// Exercise 6.5
        /// </summary>
        public static void RandomNumber()
        {

            int number = new Random().Next(1, 100);

            do
            {
                Console.Write("Guess the number: ");
                int guess = int.Parse(Console.ReadLine());

                if(guess > number)
                {
                    Console.WriteLine($"{guess} is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low");
                }
                else if(guess == number)
                {
                    Console.WriteLine($"Well done {guess} is correct");
                    break;
                }
            }
            while (true);
        }

    }
}
