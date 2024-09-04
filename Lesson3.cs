/* Lesson 3 Class
 * Jayden Wilson
 * 29 Aug 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    public static class Lesson3
    {
        /// <summary>
        /// Task 1 - A method that is used to 
        /// get and write inputted name to Console.
        /// </summary>
        public static void GetDisplayName_v1()
        {
            //Asks and gets name from user
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            //Outputs users name to Console
            Console.WriteLine(name);
        }

        /// <summary>
        /// Task 2 - A method that is used to 
        /// get inputted first name and last 
        /// name and combine to wite to Console.
        /// </summary>
        public static void GetDisplayName_v2()
        {
            //Asks and gets first name from user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Asks and gets last name from user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Outputs users full name to Console
            Console.WriteLine($"{firstName} {lastName}");
        }

        /// <summary>
        /// Task 3 - A method that is used to 
        /// display text format options.
        /// </summary>
        public static void TextFormatting()
        {
            string message = "Hello World!";

            //Checks to see if the word "World" exists in the message
            Console.WriteLine(message.Contains("World"));

            //Gets first index of 'o'
            Console.WriteLine(message.IndexOf('o'));

            //Outputs the length of the message
            Console.WriteLine(message.Length);

            //Replaces the word "Hello" with "Hi"
            Console.WriteLine(message.Replace("Hello", "Hi"));
        }

        /// <summary>
        /// Exercise 3.1 - A method that is used to 
        /// write a small story to Console.
        /// </summary>
        public static void SmallStory()
        {
            //Asks and gets first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();


            //Asks and gets users favourite colour
            Console.Write("What is your favourite colour? ");
            string favouriteColour = Console.ReadLine();

            //Uppercase first letter and makes the rest lowercase
            favouriteColour = favouriteColour.Substring(0, 1).ToUpper() + favouriteColour.Substring(1).ToLower();


            //Asks and gets users favourite food
            Console.Write("What is your favourite food? ");
            string favouriteFood = Console.ReadLine();

            //Lowercase all letters
            favouriteFood = favouriteFood.ToLower();


            //Outputs small story to Console
            Console.WriteLine($"{firstName} ate a {favouriteColour} {favouriteFood}");
        }

        /// <summary>
        /// Exercise 3.2 - A method that is used to 
        /// format "Hello World!".
        /// </summary>
        public static void Casing()
        {
            //Asks and gets first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

            //Asks and gets name of user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Uppercase first letter and makes rest lowercase
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

            //Outputs full name to Console
            Console.WriteLine($"{firstName} {lastName}");
        }

        /// <summary>
        /// Exercise 3.3 - A method that is used to 
        /// create a postcode from 4 inputs / parts
        /// </summary>
        public static void Postcode()
        {
            int inputCount = 4; //Variable for amount of inputs / parts to the postcode
            string postcode = null; //Variable for full postcode

            //Loop to ask and get specific part of the postcode from user
            for (int i = 0; i < inputCount; i++)
            {
                //Asks and gets user input 
                Console.Write($"Postcode part {i + 1}? ");
                postcode += Console.ReadLine().ToUpper().ToString();

                //A check so at the second iteration a space is added in the postcode
                if (i == 1)
                {
                    postcode += " ";
                }
            }

            //Outputs postcode to console
            Console.WriteLine(postcode);

        }
    }
}
