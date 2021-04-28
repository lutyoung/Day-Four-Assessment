namespace longestPrefix
{
    public class FindCommonPrefixBetweenStrings
    {

        // A Utility Function to find
        // the common prefix between
        // strings- str1 and str2
        static string commonPrefixUtil(string str1,
                                       string str2)
        {
            string result = "";
            int n1 = str1.Length,
                n2 = str2.Length;

            // Compare str1 and str2
            for (int i = 0, j = 0;        // loop through both strings 
                     i <= n1 - 1 && j <= n2 - 1;
                     i++, j++)
            {
                if (str1[i] != str2[j])
                {
                    break;
                }
                result += str1[i];
            }

            return (result);
        }

        // A Method that returns the longest
        // common prefix from the array of strings
        public static string CommonPrefix(string[] arr, int n)
        {
            string prefix = arr[0];

            for (int i = 1; i <= n - 1; i++)
            {
                prefix = commonPrefixUtil(prefix,
                             arr.GetValue(i).ToString());
            }

            return (prefix);
        }
    }
}
