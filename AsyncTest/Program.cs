using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        /// <summary>
        /// The delegate is added in the for loop and “reference” 
        /// (or perhaps “pointer” would be a better choice of words) 
        /// to i is stored, rather than the value itself. 
        /// Therefore, after we exit the loop, the variable i has been 
        /// set to 10, so by the time each delegate is invoked, 
        /// the value passed to all of them is 10.
        /// </summary>
        delegate void Printer();

        static void Main()
        {
            // List of delegates
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }

            Console.WriteLine("Press a key...");
            Console.ReadLine();
        }
    }
}