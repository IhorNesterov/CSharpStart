//#define Debug
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0 + 1 = 3 - 1 = 1 * 3 = 40 / 10 =";
            string[] output = App.Calculate(App.Parse(input));
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
            Console.ReadLine();
        }
    }
}
