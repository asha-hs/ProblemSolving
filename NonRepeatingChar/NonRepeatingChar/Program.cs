using System;

namespace NonRepeatingChar
{
    class Program
    {
        public static int FirstNonRepeatingIndex(string str)
        {
            int res = Int32.MaxValue;
            int[] fi = new int[26];

            for(int i = 0; i < 26; i++)
            {
                fi[i] = -1;
            }

            for(int i = 0; i< str.Length; i++)
            {
                if(fi[str[i]-'a'] == -1)
                {
                    fi[str[i]-'a'] = i;
                }else
                {
                    fi[str[i]-'a'] = -2;
                }
            }

            for(int i = 0; i < 26; i++)
            {
                if(fi[i] >= 0)
                {
                    res = Math.Min(res, fi[i]);
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string str = "aabc";
            int FirstIndex = FirstNonRepeatingIndex(str);
            if (FirstIndex == -1) Console.WriteLine("No non repeating characters in the given string");
            else Console.WriteLine($"First non repeating char is {str[FirstIndex]}");
        }
    }
}
