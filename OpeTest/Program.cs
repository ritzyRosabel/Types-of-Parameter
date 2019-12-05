using System;

namespace OpeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //named parameter
            Console.WriteLine(Opee.Call(s2: "Geek", s3: "call", s1: "me")); 
            Console.WriteLine(Opee.calling(s1: 2, s2: 34));

            // ref parameter
            string vall = "dog";
            Opee.val(ref vall);
            Console.WriteLine(vall);
           int  y = 5;
           Opee.cube(ref y);
            int x = 10;
           Console.WriteLine(x+" "+ y);
           Opee.mult(ref x, ref y);
           Console.WriteLine(x + " " + y);

            // out parameter
            int a, b;
            a =  Opee.square(10, out b);
            Console.WriteLine("the area of the square with side 10 cm is :" + a);
            Console.ReadLine();

        }
    }
}
