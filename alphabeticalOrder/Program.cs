using System;

namespace alphabeticalOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp; // declare variable temp

            Console.WriteLine("Enter Any String");

            string userInput = Console.ReadLine();


            string str = userInput.ToLower(); // Convert userInput to lowercase

            char[] charstr = str.ToCharArray();  // convert inputString to Array of characters

            for (int i = 1; i < charstr.Length; i++)  // loop through the elements of the array from the first index 
            {
                for (int j = 0; j < charstr.Length - 1; j++)  // loop through elements of the array from the second index
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr);

            Console.ReadLine();
        }
    }
}
