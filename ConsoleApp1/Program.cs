#define Debug
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = { 3, 4, 5 };
            Student debich = new Student(21, 80, "Nesterov Ihor", "Politekh", App.Parse("Math Physics Programming"), mark);
            Console.WriteLine(debich.Display());
            Console.ReadLine();
        }
    }
}
