/* Lesson 4 Class
 * Jayden Wilson
 * 04 Sep 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Development
{
    public static class Lesson4
    {
        /// <summary>
        /// Task 1 - A method that is used to 
        /// write min and max lengths of number 
        /// types  to Console.
        /// </summary>
        public static void MinMax()
        {
            //Signed Integers
            Console.WriteLine("Signed Integers");
            Console.WriteLine($"Int Max: {int.MaxValue}");
            Console.WriteLine($"Int Min: {int.MinValue}");
            Console.WriteLine($"short Max: {short.MaxValue}");
            Console.WriteLine($"short Min: {short.MinValue}");
            Console.WriteLine($"Sbyte Max: {sbyte.MaxValue}");
            Console.WriteLine($"Sbyte Min: {sbyte.MinValue}");
            Console.WriteLine($"long Max: {long.MaxValue}");
            Console.WriteLine($"long Min: {long.MinValue}");
            Console.WriteLine("");

            //Unsigned Integers
            Console.WriteLine("Unsigned Integars");
            Console.WriteLine($"Uint Max: {uint.MaxValue}");
            Console.WriteLine($"Uint Min: {uint.MinValue}");
            Console.WriteLine($"Ushort Max: {ushort.MaxValue}");
            Console.WriteLine($"Ushort Min: {ushort.MinValue}");
            Console.WriteLine($"byte Max: {byte.MaxValue}");
            Console.WriteLine($"byte Min: {byte.MinValue}");
            Console.WriteLine($"Ulong Max: {ulong.MaxValue}");
            Console.WriteLine($"Ulong Min: {ulong.MinValue}");
            Console.WriteLine("");

            //Other Integers
            Console.WriteLine("Other Integers");
            Console.WriteLine($"float Max: {float.MaxValue}");
            Console.WriteLine($"float Min: {float.MinValue}");
            Console.WriteLine($"decimal Max: {decimal.MaxValue}");
            Console.WriteLine($"decimal Min: {decimal.MinValue}");
            Console.WriteLine($"double Max: {double.MaxValue}");
            Console.WriteLine($"double Min: {double.MinValue}");
        }

        /// <summary>
        /// Task 2 - A method that is used to 
        /// write simple math to Console.
        /// </summary>
        public static void SimpleMath()
        {
            //12 x 45
            Console.WriteLine($"12 x 45 = {12*45}");

            //10 / 3 
            Console.WriteLine($"10 / 3 = {10 / 3}");

            //10 / 3 
            Console.WriteLine($"10 / 3 = {10d / 3d:f3}");

            //Remainder of 10 / 3
            Console.WriteLine($"Remainder of 10 / 3 = {10 % 3}");

            //32768 + 512
            Console.WriteLine($"32768 + 512 = {32768 + 512}");

            //16384 - 4431
            Console.WriteLine($"16384 - 4431 = {16384 - 4431}");

            //64 ^ 3
            Console.WriteLine($"64 ^ 3 = {Math.Pow(64, 3)}");
        }

        /// <summary>
        /// Task 3 - A method that is used to 
        /// write get and display total earnings 
        /// of user to Console.
        /// </summary>
        public static void Salary()
        {
            //Asks and gets salary from user
            Console.Write("Please enter your salary: ");
            int salary = int.Parse(Console.ReadLine());

            //Asks and gets bonus from user
            Console.Write("Please enter your bonus: ");
            int bonus = int.Parse(Console.ReadLine());


            //Displays total to console in currency format
            Console.WriteLine($"Total: {salary + bonus:C2}");
        }

        
        public static void LoanCalculation()
        {
            double amount = 0;
            double interest = 0;
            double years = 0;
            double monthlyTotal = 0;

            //Asks and gets loan amount from user
            Console.Write($"Loan Amount: ");
            amount = double.Parse(Console.ReadLine());

            //Asks and gets interest rate from user
            Console.Write($"Interest Rate: ");
            interest = double.Parse(Console.ReadLine());
            interest = interest / 100 / 12;

            //Asks and gets years from user
            Console.Write($"Years: ");
            years = double.Parse(Console.ReadLine());
            years = years * 12;

            //Outputs the monthly payments of the loan to Console
            monthlyTotal = amount * (interest / (1 - (Math.Pow(1 / 1 + interest, -years))));
            Console.WriteLine($"Total Monthly: {monthlyTotal:F2}");
        }

        /// <summary>
        /// Exercise 4.1
        /// </summary>
        public static void Adding()
        {
            int first = 0;
            int second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());

            //Ouputs anwser to console
            Console.WriteLine($"{first} + {second} = {first+second}");
        }

        /// <summary>
        /// Exercise 4.2
        /// </summary>
        public static void Dividing()
        {
            float first = 0;
            float second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = float.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = float.Parse(Console.ReadLine());

            //Ouputs anwser to console with formaatting
            Console.WriteLine($"{first:0.000} / {second:0.000} = {first / second:0.000}");
        }

        /// <summary>
        /// Exercise 4.3
        /// </summary>
        public static void DividingRemainder()
        {
            int first = 0;
            int second = 0;

            //Asks and gets first number from user
            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());

            //Asks and gets second number from user
            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());

            //Ouputs anwser to console
            Console.WriteLine($"{first} / {second} = {first / second} remainder {first % second}");
        }

        /// <summary>
        /// Exercise 4.4
        /// </summary>
        public static void Circle()
        {
            float diameter = 0;
            float circumference = 0;
            float area = 0;

            //Asks and gets diameter from user
            Console.Write("Enter diameter of circle (cm): ");
            diameter = float.Parse(Console.ReadLine());

            //Calculates the circumference and area
            circumference = (float)(Math.PI * diameter);
            area = (float)(Math.PI * (Math.Pow(diameter / 2, 2)));

            //Ouputs anwser to console
            Console.WriteLine($"Circumference of circle (cm): {circumference:0.000}");
            Console.WriteLine($"Area of circle (cm2): {area:0.000}");

        }
    }
}
