using System;

namespace Fibbo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 18;

            for(int i=0;i <= n-1; i++)
            {
                Console.Write(Fibbo(i) + " ");
            }
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        public static int Fibbo(int n)
        {
            if (n == 0 || n == 1) return n;

            return (Fibbo(n - 1) + Fibbo(n - 2));
        }
    }
}