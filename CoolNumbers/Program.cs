using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CoolNumbers
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        //static void Main(string[] args)
        //{
        //    long coolSum = 70601040511;
        //    Post37(coolSum, 0);
        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadLine();
        //}

        //static async void Post37(long coolSum, int codeCount)
        //{
        //    int[] arr = new int[] { 85,89,92, 94, 100 };

        //    for (int cnt = 0; cnt < 5; cnt++)
        //    {
        //        client.DefaultRequestHeaders.Add("X-COOL-SUM", coolSum.ToString());
        //        var response = await client.PostAsync("http://dev.getethos.com/code" + arr[cnt], null);
        //        var data = await response.Content.ReadAsStringAsync();
        //        Console.WriteLine(data);
        //        Thread.Sleep(1000);
        //    }
        //}

        static void Main(string[] args)
        {
            long coolSum = 0;
            double sum = 0;
            for (int number = 1; number <= 1000000; number++)
            {
                sum = number;
                while (true)
                {
                    sum = Compute(sum);
                    if (sum == 1)
                    {
                        Console.WriteLine("cool number:" + number);
                        coolSum += number;
                        break;
                    }

                    if (sum == 4)
                        break;
                }
            }

            Console.WriteLine("coolSum:" + coolSum);

            for (int cnt = 0; cnt < 100; cnt++)
            {
                int codeCount = cnt + 1;
                Console.WriteLine("cnt[" + (cnt + 1) + "] number: " + coolSum + " , code: " + Post(coolSum, codeCount).Result);
                Thread.Sleep(100);
            }

            Console.WriteLine("Press Enter:");
            Console.ReadLine();

        }

        static int[] Digits(double data)
        {
            string number = data + "";
            return number.ToCharArray().Select(digit => int.Parse(digit.ToString())).ToArray();
        }

        static double Compute(double number)
        {
            int[] digits = Digits(number);

            double sum = 0;
            for (int cnt = 0; cnt < digits.Length; cnt++)
            {
                sum += Math.Pow(digits[cnt], 2);
            }

            return sum;
        }

        static async Task<string> Post(long coolSum, long code)
        {
            client.DefaultRequestHeaders.Add("X-COOL-SUM", coolSum.ToString());
            string url = "http://dev.getethos.com/code" + code;
            Console.WriteLine("url: " + url + " coolSum: " + coolSum.ToString());
            var response = await client.PostAsync(url, null);
            return await response.Content.ReadAsStringAsync();
        }

    }
}