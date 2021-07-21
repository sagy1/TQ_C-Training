using System;

namespace IfElseLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            if (num > 0)
            {
                Console.WriteLine("Possitive Number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negetive Number");
            }

            else if (num == 0)
            {
                Console.WriteLine("number is Zero");
            }
                      
        }
    }
}
