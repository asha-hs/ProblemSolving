using System;

namespace LCSubstring
{
    class Program
    {

        public static int LCSubstring(string s1,string s2)
        {
            int n = s1.Length;
            int m = s2.Length;

            if (n == 0 || m == 0) return 0;
            int lcs = 0;

            int[,] arr = new int[n,m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(s1[i] == s2[j])
                    {
                        if (i > 0 && j > 0)
                            arr[i, j] = 1 + arr[i - 1, j - 1];
                        else
                            arr[i, j] = 1;
                        lcs = Math.Max(lcs, arr[i, j]);
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            return lcs;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String X = "abxyz";
            String Y = "xyzab";

            

            Console.Write("Length of Longest Common"
                          + " Substring is "
                          + LCSubstring(X, Y));
        }
    }
}
