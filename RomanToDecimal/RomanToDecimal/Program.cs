using System;

namespace RomanToDecimal
{
    class Program
    {
        public static int Getvalue(char c)
        {
            /*
             * I 1
V 5
X 10
L 50
C 100
D 500
M 1000
            */

            if (c == 'I')
                return 1;
            if (c == 'V')
                return 5;
            if (c == 'X')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;
            return -1;
        }

        public static int RomanToDecimal(string str)
        {
            int res = 0;
            int len = str.Length;
            for(int i = 0; i < len; i++)
            {
                int s1 = Getvalue(str[i]);

                if(i+1 < len)
                {
                    int s2 = Getvalue(str[i + 1]);
                    if(s1 >= s2)
                    {
                        res = res + s1;
                    }else
                    {
                        res = res + s2 - s1;
                        i++;
                    }
                }
                else
                {
                    res = res + s1;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "MCMIV";
            Console.WriteLine("Integer form of Roman Numeral"
                              + " is "
                              + RomanToDecimal(str));
            Console.WriteLine("Integer form of Roman Numeral"
                              + " is "
                              + RomanToDecimal("V"));
            Console.WriteLine("Integer form of Roman Numeral"
                              + " is "
                              + RomanToDecimal("XC"));
            Console.WriteLine("Integer form of Roman Numeral"
                              + " is "
                              + RomanToDecimal("2"));
        }
    }
}
