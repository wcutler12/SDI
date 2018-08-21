using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables - Characters

            //Characters - char - onlye the size of ONE character
            //Must be surrounded by single quotes ''

            //Declare a varible
            char firstLetter;

            //Define a variable
            firstLetter = 'a';

            //Print the variable to our console
            Console.WriteLine(firstLetter);

            //Declare AND Define a variable in one step
            char secondCharacter = 'b';

            //Print the new variable to the console
            Console.WriteLine(secondCharacter);

            //String of characters - string - basically anything bigger than a single character
            //Must be surrounded by double quotes ""

            string wholeSentence = "This is an example of a sentence.";

            //Print the string variable to the console
            Console.WriteLine(wholeSentence);

            //Combine Strings together
            // Use plus sign - Concatenation
            string combinedString = "First Part " + "Second Part";
            Console.WriteLine(combinedString);

            //Spaces?
            string firstName = "Kermit";
            string lastName = "The Frog";
            string wholeName = firstName + " " + lastName;

            Console.WriteLine(wholeName);

        }
    }
}
