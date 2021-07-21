using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[5];

            Console.WriteLine("Enter A Num");
            for (int i = 0; i < arr.Length; i++) {
                int num = Convert.ToInt32(Console.ReadLine());
            }

            
        }
    }
}
