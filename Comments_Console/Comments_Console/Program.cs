using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             William Cutler
             SDI Section 01
             Comments & Console
             08/03/2018
             */
            //This is a single line comment.
            /*
            This is a multi-lined comment! 
            Just another line.
             */

            //The Console.WriteLine will put a text string onto the console and a new line character at the end of it!
            Console.WriteLine("This will print to the console.");
            Console.WriteLine("This is an example of a second line.");

            //Console.Write will put it on the same line
            Console.Write("This an example of a Console Write.\r\n");
            Console.Write("Another line of text.");
            Console.Write("\r\n");
            Console.WriteLine("Welcome to SDI!");

            //Carriage Return \r
            //New Line Character \n
            //We will use for a new line character \r\n
        }
    }
}
