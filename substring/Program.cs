using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first word: "); // Accept first userInput
            string firstUserInput = Console.ReadLine();

            firstUserInput = firstUserInput.ToLower(); // convert first input to lowercase


            Console.Write("Enter your second word: "); // Accept second input

            string secondUserInput = Console.ReadLine();

            secondUserInput = secondUserInput.ToLower(); // Convert second input to lowercase

            string lowestString = firstUserInput.Length < secondUserInput.Length ? firstUserInput : secondUserInput;   // Check the lowest string 

            if (firstUserInput.IndexOf(secondUserInput) != -1)
            {
                Console.WriteLine("The second input is a substring of the first");
            }
            else
            {
                Console.WriteLine("The second input is not a substring of the first");
            }
        }
    }
}
