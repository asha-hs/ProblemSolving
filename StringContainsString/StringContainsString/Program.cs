using System;

namespace StringContainsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IS HelloWorld containd Worl at "+ StrStr("HelloWorld","Worl"));
            Console.WriteLine("IS HelloWorld containd Worl at " + EfficientStrStr("Welcome", "com"));
            Console.WriteLine("IS HelloWorld containd Worl at " + EfficientStrStr("Welccome", "com"));
        }


        public static int EfficientStrStr(string s, string x)
        {
            int counter = 0; //pointing s2
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (counter == x.Length)
                    break;
                if (x[counter] == s[i])
                {
                    counter++;
                }
                else
                {
                    //Special case where character preceding the i'th character is duplicate
                    if (counter > 0)
                    {
                        i -= counter;
                    }
                    counter = 0;
                }
            }
            return counter < x.Length ? -1 : i - counter;
        }
        public static int StrStr(string s, string x)
        {
            int m = x.Length, n = s.Length;

            int i, j;

            for(i = 0; i < n; i++)
            {
                j = 0;
                if(s[i] == x[j])
                {
                    for(j = 1; j < m; j++)
                    {
                        if (s[i + j] != x[j])
                            break;
                    }

                    if (j == m) return i;
                }
            }
            return -1;
        }
    }
}
