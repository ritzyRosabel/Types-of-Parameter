using System;

namespace OpeTest
{
    public  class Opee
    {
        //name parameter
        public static string Call(string s1, string s2,string s3)
        {
            return s1 + s2 + s3;
        }

        public static int calling(int s1, int s2)
        {
            return s1 + s2;
        }
        //ref parameter
        public static void val( ref string val1)
        {
            if (val1 == "dog")
            {
              Console.WriteLine("matched");
            }

            val1 = "cat";
        }
        public static void cube(ref int x)
        {
            x = x * x * x;
            Console.WriteLine(x);
        }

        public static void mult(ref int x, ref int y)
        {
            x = x * y;
        }
        //out parameter
        public static int square(int a, out int b)
        {
            b = a * a;
            return b;
        }
    }
}
