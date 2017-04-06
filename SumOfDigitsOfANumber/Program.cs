using System;

namespace SumOfDigitsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum(12) --> " + sum(12));
            Console.WriteLine("sum(45) --> " + sum(45));
            Console.ReadKey();
        }

        public static int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}