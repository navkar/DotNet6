using System;
using System.Collections.Generic;

namespace RemoveDuplicateChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RemoveDuplicates");
            Console.WriteLine(RemoveDuplicates("Gooooooooooooooooogle"));
            Console.ReadKey();

        }

        static string RemoveDuplicates(string sample)
        {
            var list = new List<char>();

            foreach(var item in sample)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
            return new string(list.ToArray());
        }

    }
}