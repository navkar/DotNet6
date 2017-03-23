using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                for (int cnt = args.Length - 1; cnt >= 0; cnt--)
                {
                    Console.Write(args[cnt] + " ");
                }
            }

            Person p = new Person();
            p.Age = 0;
            WriteLine("This persons age is " + p.FindAge());

            // Reverse a string
            string reverse = StrUtil.ReverseString("I want to reverse this string");
            WriteLine(reverse);
            
            //Example();

            //string result = ReadLine();
            //WriteLine("You typed: " + result);

            PrintMe("This is an expression bodied method");

            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        static async void Example()
        {
            // This method runs asynchronously.
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + t);
        }

        static void PrintMe(string message) => WriteLine(message);
        
        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    if (value == null)
                    {
                        return 0;
                    }
                    size += value.Length;
                }
            }
            return size;
        }
    }
}
