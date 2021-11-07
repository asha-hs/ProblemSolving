using System;
using System.Text;

namespace RotateString
{
    class Program
    {

        public static Boolean AreStringEqual(string s1, string s2)
        {
            StringBuilder clock_rot = new StringBuilder();
            StringBuilder anticlock_rot = new StringBuilder();

            clock_rot = clock_rot.Append(s2.Substring(s2.Length - 2, 2)).Append(s2.Substring(0, s2.Length - 2));
            anticlock_rot = anticlock_rot.Append(s2.Substring(2)).Append(s2.Substring(0, 2));

            return (s1.Equals(clock_rot.ToString()) || s1.Equals(anticlock_rot.ToString()));


            /* direction 1 for anti clockwise
            if (direction == 1)
            {

                string modstring = s1.Substring(2) + s1.Substring(0, 2);
                Console.WriteLine("modstring = " + modstring);
                if (modstring.Equals(s2)) return true;
                else return false;
            }
            else
            {
                string modstring = s1.Substring(s1.Length - 2, 2) + s1.Substring(0, s1.Length - 2);
                Console.WriteLine("modstring = " + modstring);
                if (modstring.Equals(s2)) return true;
                else return false;
            }
            */
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(AreStringEqual("amazon", "azonam"));
            Console.WriteLine(AreStringEqual("amazon", "onamaz"));
            Console.WriteLine(AreStringEqual("geeks", "eksge"));
            Console.WriteLine(AreStringEqual("geeksa", "eksge"));
        }
    }
}
