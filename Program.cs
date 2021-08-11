using System;

namespace EX06ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 2;
            int b = 4;

            Console.WriteLine(a == b); //False
            Console.WriteLine(a>b); //False
            Console.WriteLine(a <= b); //True
            Console.WriteLine(a-b > 0); //False
            Console.WriteLine(a+b > 0); //True
            Console.WriteLine(a > 1-b); //True


            Console.ReadKey();
        }
    }
}
