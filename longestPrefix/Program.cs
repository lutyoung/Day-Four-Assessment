using System;

namespace longestPrefix
{
    class Program
    {
        
        static void Main()
        {
            string[] arr = {"codelearners", "codeforall",
                    "codeislife", "codelearnershub"};  // Declare Array of strings

            int n = arr.Length;  // get the length of the arraray

            string ans = FindCommonPrefixBetweenStrings.CommonPrefix(arr, n);  // Call the common preffix class in the GFG class

            if (ans.Length > 0)
            {
                Console.Write("The longest common " +
                               "prefix is - " + ans);
            }
            else
            {
                Console.Write("There is no common prefix");
            }
        }

            }
}
