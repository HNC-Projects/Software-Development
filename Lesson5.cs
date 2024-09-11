/* Lesson 4 Class
 * Jayden Wilson
 * 11 Sep 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    public static class Lesson5
    {

        /// <summary>
        /// Task 1 - A method that is used to 
        /// calculate two numbers
        /// </summary>
        public static void Sum()
        {
            Console.Write("What is 3 + 4? ");
            int answer = int.Parse(Console.ReadLine());

            //Check if answer is correct
            if(answer == 7)
            {
                Console.WriteLine("Well done that is correct!");
            }

            Console.WriteLine("The test is now complete.");
        }


        /// <summary>
        /// Task 2 - A method that is used to 
        /// calculate wat a user can win with 
        /// their deposit
        /// </summary>
        public static void Deposit()
        {
            Console.Write("How much would you like to deposit? ");
            int deposit = int.Parse(Console.ReadLine());

            //Check if deposit is over 100
            if (deposit > 100)
            {
                Console.WriteLine("You get a free toaster!");
            }
            else
            {
                Console.WriteLine("Enjoy your mug?");
            }
        }

        /// <summary>
        /// Challenge Task 1 - A method that is used to 
        /// calculate the shipping cost of a users 
        /// shopping
        /// </summary>
        public static void Shipping()
        {
            double total;
            double normalShippingCost = 10; //Sets value of normal shipping
            double expressShippingCost = 15; //sets value of express shipping

            Console.Write("Enter shopping total: ");
            double shoppingTotal = int.Parse(Console.ReadLine());

            Console.Write("Do you want express shipping (yes|no)? ");
            string expressShipping = Console.ReadLine();

            //if express shipping is equal to yes with no casing issues
            if (expressShipping.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                //Calculate total
                total = shoppingTotal + expressShippingCost;
                Console.WriteLine($"That will be an extra {expressShippingCost:C2} for shipping");
            }
            else
            {
                //Check if shopping total is less than 50
                if (shoppingTotal < 50)
                {
                    total = shoppingTotal + normalShippingCost;
                    Console.WriteLine($"That will be an extra {normalShippingCost:C2} for shipping");
                }
                else
                {
                    //Calculate total
                    total = shoppingTotal;
                    Console.WriteLine("You qualify for free shipping");
                }
            }

            Console.WriteLine($"Your final total including shipping is {total:C2}");
        }

        /// <summary>
        /// Task 3 - A method that is used to 
        /// calculate what a user can win with 
        /// their deposit
        /// </summary>
        public static void Lottery()
        {
            double bigWin = 1000000;

            Console.Write("Did you win the lottery? (true|false) ");
            bool wonLottery = bool.Parse(Console.ReadLine());

            //Checks to see if you did win the lottery
            if(wonLottery == true)
            {
                Console.Write($"Did you win big. over {bigWin:C2}. (true|false) ");
                bool wonBigWin = bool.Parse(Console.ReadLine());

                //Checks if you won the lottory and it was a big win
                if (wonLottery == true && wonBigWin == true)
                {
                    Console.WriteLine("You can retire.");
                }
                else
                {
                    Console.WriteLine("You cannot retire.");
                }
            }
            else
            {
                Console.WriteLine("You cannot retire.");
            }
        }

        /// <summary>
        /// Task 4 - A method that is used to 
        /// calculate what a user can win with 
        /// their deposit
        /// </summary>
        public static void Animals()
        {
            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("Pet: ");
            string pet = Console.ReadLine();

            //Checks if country is Canada and if moose or beaver is the pet 
            if(country == "CANADA" && (pet == "MOOSE" || pet == "BEAVER")) //Treats it as separate statements until ()
            {
                Console.WriteLine("Do you play hocky too?");
            }
        }

        /// <summary>
        /// Challenge Task 2 - A method that is used to 
        /// calculate the total cost including taxes
        /// depending on location for the user
        /// </summary>
        public static void SalesTax()
        {
            double taxes = 0;
            double total = 0;
            string province = "";
            string country = "";

            Console.Write("What country do you live in? ");
            country = Console.ReadLine();

            //Checks if country is Canada
            if(country == "Canada")
            {

                Console.Write("What province? ");
                province = Console.ReadLine();

                //Checks users province
                if (province == "Alberta")
                {
                    taxes = 5; //Changes tax amount
                }
                else if (province == "Ontario" || province == "New Brunswick" || province == "Nova Scoti")
                {
                    taxes = 13; //Changes tax amount
                }
                else
                {
                    taxes = 11; //Changes tax amount
                }
            }
            else
            {
                taxes = 0; //Changes tax amount
            }

            Console.Write("What is the total order cost ");
            double orderCost = int.Parse(Console.ReadLine());

            //Calculates total cost including tax
            total = orderCost + orderCost * (taxes / 100);

            Console.WriteLine($"\nTotal cost including taxes: {total:C2}");
        }

        /// <summary>
        /// Exercise 5.1 - A method that is used to 
        /// see if the user is retired or in school
        /// </summary>
        public static void Age()
        {
            Console.Write("What is your age. ");
            int age = int.Parse(Console.ReadLine());

            //Checks if age is less than 16
            if(age < 16)
            {
                Console.WriteLine("You are still at school");
            }

            //Checks if age is more than 66
            else if (age > 66)
            {
                Console.WriteLine("You are retired, lucky you!");
            }
        }

        /// <summary>
        /// Exercise 5.2 - A method that is used to 
        /// see if a number is positive or negative
        /// </summary>
        public static void PositiveNegative()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //Checks if number is less than 0
            if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }

            //Checks if number is more than 0
            else if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
        }

        /// <summary>
        /// Exercise 5.3 - A method that is used to 
        /// see if a number is positive or negative
        /// </summary>
        public static void HighestValue()
        {
            int highestNumber = 0;
            int[] numbers = new int[3]; //Array that stores 3 numbers
           
            //Loop code 3 times
            for (int i = 0; i < 3; i++)
            {
                //Ask user fo a number
                Console.Write($"Enter number {i+1}: ");
                int newNumber = int.Parse(Console.ReadLine());

                //Add number to array
                numbers[i] = newNumber; 

                //Check if number is higher than the current highest
                if (newNumber > highestNumber)
                {
                    //Makes teh current highest number the new number
                    highestNumber = newNumber;
                }
            }

            //Separate values in array with , and turn into one string
            string numbersList = string.Join(", ", numbers);

            Console.WriteLine($"Out of {numbersList}. the highest number is {highestNumber}");
        }
    }
}
