#define Debug
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjects = "Khimia Physics Math";
            int[] marks = { 3, 4, 5 };
            Student debich = new Student(20, 70, "Nestrov", "Politekh",App.Parse(subjects),marks);
            Console.WriteLine(debich.Display());
            Console.ReadLine();
        }
    }
}
