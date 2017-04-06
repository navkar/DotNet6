using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Employee : IComparable
    {
        public string Name
        {
            get;set;
        }

        public int Age
        {
            get;set;
        }

        public int CompareTo(object obj)
        {
            var employee = (Employee)obj;
            return ((IComparable)Age).CompareTo(employee.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> list = new List<Employee>();

            //list.Add(new Employee() { Name = "Naveen", Age = 36 });
            //list.Add(new Employee() { Name = "Pooja Kashyap", Age = 31 });
            //list.Add(new Employee() { Name = "Katyal", Age = 34 });
            //list.Add(new Employee() { Name = "Nishant Nepal", Age = 33 });

            //list.Sort();

            //var array = list.ToArray();

            //for (int i=0;i <list.Count; i++)
            //{
            //    System.Console.WriteLine("i =" + i + "name:" + array[i].Name);
            //}

            int[] numbers = { 10, 4323, 23, 340, 4045, 9, 2303, 34, 485 };

            for(int i=0; i< numbers.Length-1; i++)
            {
                for (int j=i+1;j< numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            


                Console.WriteLine("Press enter to exit...");
            Console.ReadLine();

        }
    }
}