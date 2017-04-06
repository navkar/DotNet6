using System;
using System.Linq;

namespace AWS
{
    class Program
    {
        static String location;
        static DateTime time;

        static void Main(string[] args)
        {
            int[] numbers = { 10, 13, 15, 16, 19 };
            Console.WriteLine("Sum = " + SumOfEvenNumbers(numbers));

            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());

            Circle circle = new Circle();
            var radius = circle.Calculate(r => r);
            var circumference = 2 * Math.PI * radius;
            Console.WriteLine("radius = " + radius);
            Console.WriteLine("circumference = " + circumference);

            Console.ReadLine();
        }
        
        public static long SumOfEvenNumbers(int[] numbers)
        {
            return numbers.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }


}