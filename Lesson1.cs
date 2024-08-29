/* Lesson 1 Class
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
    public static class Lesson1
    {
        /// <summary>
        /// Task 1 - A method that is used to 
        /// write "Hello World!" to Console.
        /// </summary>
        public static void HelloWorld_v1()
        {
            //Writes "Hello World" to Console
            Console.Write("Hello World!");
        }

        /// <summary>
        /// Task 2 - A method that is used to 
        /// write "Hello World!" to Console 
        /// on separate lines.
        /// </summary>
        public static void HelloWorld_v2()
        {
            //Writes "Hello World" to Console.
            Console.WriteLine("Hello");
            Console.WriteLine("World!");
        }

        /// <summary>
        /// Exercise 1.1 - A method that is used to 
        /// write a message that includes ""
        /// </summary>
        public static void Message()
        {
            //Writes a message to Console with "" included
            Console.Write("The teacher says \"I'm a good programmer!\" ");
        }
    }
}
