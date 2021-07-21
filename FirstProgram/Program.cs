using System;
using AccessModifier;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Class");
            Class1 obj = new Class1();
            int x = obj.add();
            Console.WriteLine(x);
        }
    }
}
