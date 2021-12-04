using System;
using System.Collections.Generic;

namespace LongestCommonPrefix
{
    class Program
    {

        public static string LongestCPrefic(string[] arr)
        {
            if (arr == null || arr.Length == 0) return "";

            for (int j = 0; j < arr[0].Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[0][j] != arr[i][j])
                        return arr[0].Substring(0, j);
                }
            }

            return "";
        }
        static void Main(string[] args)
        {
            string[] strarr = new string[] { "apple", "ape", "april" };
            Console.WriteLine("Longest common prefix is  "+ LongestCPrefic(strarr));
            
        }
    }
}
