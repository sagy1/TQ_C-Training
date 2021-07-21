using System;

namespace UnaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y;
            y = x++;
           Console.WriteLine("Post increment of num is " + x);

            //-------------------------
            int a = 5;
            int b;
            b = a--;
            Console.WriteLine("Post decrement of num is " + b);

            //-----------------------

            int c = 5;
            int d;

            d = ++c;
            Console.WriteLine("Pre increment of num is " + d);

            //------------------------------


            int j = 5;
            int k;
            k = --j;
            Console.WriteLine("Pre decrement of num is " + k);
        }
    }
}
