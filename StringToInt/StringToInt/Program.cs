using System;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert string 1234 to num = "+ AtoI("1234"));
            Console.WriteLine("Convert string abc12 to num = " + AtoI("abc123"));
            Console.WriteLine("Convert string 123s4 to num = " + AtoI("123s4"));
        }

        public static int AtoI(string str)
        {
            if (str.Length == 0) return -1;

            int sign = 1, i = 0, res = 0; ;

            if(str[i] == '-')
            {
                sign = -1;
                i++;
            }

            for(; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return -1;
                else
                {
                    res = res * 10 + str[i] - '0';
                }
            }

            return res * sign;
        }
    }
}
