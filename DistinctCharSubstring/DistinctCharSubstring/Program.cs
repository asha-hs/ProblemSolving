using System;

namespace DistinctCharSubstring
{
    class Program
    {
        public static int DistinctSubString(string s)
        {
            int len = s.Length;
            int maxLen = 0;
            for(int i = 0; i < len; i++)
            {
                bool[] dp = new bool[26];
                int j = i, currentLen = 0;
                while(j < len && !dp[s[j] - 'a'])
                {
                    dp[s[j] - 'a'] = true;
                    j++;
                    currentLen++;
                    
                }

                if (currentLen > maxLen)
                    maxLen = currentLen;
            }

            return maxLen;
        }

        public static string FindLongestSubstring(string str)
        {
            // base case
            if (str == null || str.Length == 0) return str;

            // stores the longest substring boundaries
            int begin = 0, end = 0;

            // boolean array to mark characters present in the current window
            Boolean[] window = new bool[128];

            // `[low…high]` maintain the sliding window boundaries
            for(int low = 0, high = 0; high < str.Length; high++)
            {
                // if the current character is present in the current window
                if (window[str[high]])
                {

                    // remove characters from the left of the window till
                    // we encounter the current character
                    while(str[low] != str[high])
                    {
                        window[str[low]] = false;
                        low++;
                    }

                    low++;     // remove the current character
                }
                else
                {
                    // if the current character is not present in the current
                    // window, include it
                    window[str[high]] = true;

                    // update the maximum window size if necessary
                    if(end - begin < high - low)
                    {
                        begin = low;
                        end = high;
                    }
                }

            }

            // return the longest substring found at `str[begin…end]`
            return str.Substring(begin, (end-begin)+1);


        }
        static void Main(string[] args)
        {
            string str = "geeksforgeeks";

            string str1 = "findlongestsubstring";
            Console.WriteLine(" Length of longest substring with all distinct character in  "+ str + " is "+ DistinctSubString(str));

            Console.WriteLine(" longest substring with all distinct character in  " + str + " is " + FindLongestSubstring(str));

            Console.WriteLine(" longest substring with all distinct character in  " + str1 + " is " + FindLongestSubstring(str1));
        }
    }
}
