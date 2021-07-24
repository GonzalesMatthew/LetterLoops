using System;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string.");
            string userInput = Console.ReadLine();

            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < userInput.Length; i++)
            {
                // grab letter
                string letter = userInput[i].ToString();
                // initialize a capitalized version of the letter
                string cap = letter.ToUpper();
                // initalize a lowercase version of the letter
                string lower = letter.ToLower();
                // convert lowercase string to char so you can use it with String
                char lowerChar = lower.ToCharArray()[0];
                // repeat string now works
                string repeat = new String(lowerChar, i);
                // use Append to build the string per each letter depending on [i]
                newString.Append(cap);
                newString.Append(repeat);
                // consider if last letter: if it is, do not attach hypen at the end
                if ((i+1) != userInput.Length)
                {
                    newString.Append('-');
                }
            }

            Console.WriteLine(newString);

        }
    }
}
