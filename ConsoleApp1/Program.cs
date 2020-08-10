using System;

namespace ConsoleApp1
{
    class Program
    {
        public static string[] Parse(string input)
        {
            int wordscount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //Console.WriteLine("Index:" + i);
                //Console.WriteLine("Char:" + input.Substring(i, 1));
                if (input.Substring(i, 1) == " ")
                {
                    wordscount++;
                }
            }
            //Console.WriteLine("wordscount:" + wordscount);
            int[] startpoints = new int[wordscount];
            int[] endpoints = new int[wordscount + 1];
            string[] output = new string[wordscount];
            int x = 1;
            endpoints[0] = 0;

            for (int k = 0; k < input.Length; k++)
            {
                if (input.Substring(k, 1) == " ")
                {
                    endpoints[x] = k + 1;
                    //Console.WriteLine("Point:" + k);
                    //Console.WriteLine("Endd:" + endpoints[x]);
                    x++;
                }
            }
            /*
            for(int i = 0; i < endpoints.Length; i++)
            {
                Console.WriteLine("Ended:" + endpoints[i]);
            }
            */
            for (int i = 1; i < wordscount + 1; i++)
            {
                output[i - 1] = input.Substring(endpoints[i - 1], endpoints[i] - endpoints[i - 1]);
                //Console.WriteLine("Endpoint:" + endpoints[i - 1]);
                //Console.WriteLine("String:" + output[i - 1]);
            }

            /*for (int i = 0; i < wordscount; i++)
            {
                Console.WriteLine("parsed:" + output[i]);
            }
            */
            return output;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            string f = "";
            for (int i = 0; i < f.Length; i++)
            {
                f += i.ToString() + " ";
            }
            for(int i = 0; i < f.Length; i++)
            {
                Console.WriteLine(f[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
