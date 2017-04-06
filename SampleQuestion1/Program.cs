using System;
using System.Collections.Generic;

namespace SampleQuestion1
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 120, 2303, 2303, 210, 201, 40, 2303};
            int goal = (int) Math.Round((double)(numbers.Length / 2));

            var store = new Dictionary<int, int>();
            int magic = -1;
            foreach (var number in numbers)
            {
                if (store.ContainsKey(number))
                {
                    store[number] = store[number] + 1;

                    if (store[number] >= goal)
                    {
                        magic = number;
                        break;
                    }
                }
                else
                {
                    store.Add(number, 1);
                }

            }

            Console.WriteLine("magic = " + magic);
            Console.ReadLine();
        }
    }
}