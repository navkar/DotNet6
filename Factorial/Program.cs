using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial(0) ==> " + Factorial(0));
            Console.WriteLine("Factorial(1) ==> " + Factorial(1));
            Console.WriteLine("Factorial(2) ==> " + Factorial(2));
            Console.WriteLine("Factorial(3) ==> " + Factorial(3));
            Console.WriteLine("Factorial(4) ==> " + Factorial(4));
            Console.WriteLine("Factorial(5) ==> " + Factorial(5));
            Console.WriteLine("Factorial(6) ==> " + Factorial(6));
            Console.WriteLine("Factorial(7) ==> " + Factorial(7));
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return (n * Factorial(n - 1));
        }


    }
}