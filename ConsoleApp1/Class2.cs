using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class App
    {
        //Method for create string array from string,where every array element is a simple word from input string,used for parsing incoming information
        public static string[] Parse(string input) 
        {
            int wordscount = 0;
            for (int i = 0; i < input.Length; i++)
            {
#if (Debug)  
                Console.WriteLine("Parse function - Index:" + i);
                Console.WriteLine("Parse function - Char:" + input.Substring(i, 1));
#endif
                if (input.Substring(i, 1) == " ")
                {
                    wordscount++;
                }
            }

            wordscount++;
#if (Debug)
            Console.WriteLine("Parse function - wordscount:" + wordscount);
#endif 
            int[] endpoints = new int[wordscount + 1];
            string[] output = new string[wordscount];
            int currentpoint = 1;
            endpoints[0] = 0;

            for (int k = 0; k < input.Length + 1; k++)
            {
                if (k == input.Length) endpoints[currentpoint] = k;
                else
                if (input.Substring(k, 1) == " ")
                {
                    endpoints[currentpoint] = k + 1;
#if (Debug)
                    Console.WriteLine("Parse function - Point:" + k);
                    Console.WriteLine("Parse function - End:" + endpoints[currentpoint]);
#endif
                    currentpoint++;
                }
            }

#if (Debug)
            for (int i = 0; i < endpoints.Length; i++)
            {
                Console.WriteLine("Parse function - Ended:" + endpoints[i]);
            }
#endif
            for (int i = 1; i < wordscount + 1; i++)
            {
                output[i - 1] = input.Substring(endpoints[i - 1], endpoints[i] - endpoints[i - 1]);
#if (Debug)
                Console.WriteLine("Parse function - Endpoint:" + endpoints[i - 1]);
                Console.WriteLine("Parse function - String:" + output[i - 1]);
            }

            for (int i = 0; i < wordscount; i++)
            {
                Console.WriteLine("Parse function - Parsed:" + output[i]);
            }
#else
            }
#endif
            return output;
        }

        //Method for arifmetical actions on the string array
        public static string[] Calculate(string[] input)
        {
            int outputvaluescount = 0;
            for (int i = 0; i < input.Length; i++)
            {
#if (Debug)  
                Console.WriteLine("Calculate function - Index:" + i);
                Console.WriteLine("Calculate function - Char:" + input.Substring(i, 1));
#endif
                if (input[i].Substring(0,1) == "=")
                {
                     outputvaluescount++;
                }
            }

            string[] output = new string[outputvaluescount];
            int count = 0;

            for(int i = 2; i < input.Length; i += 4)
            {
#if (Debug)
                Console.WriteLine("Calculate function - Index:" + i);
                Console.WriteLine("Calculate function - Operator:" + input[i - 1]);
                Console.WriteLine("Calculate function - First arg:" + int.Parse(input[i - 2]));
                Console.WriteLine("Calculate function - Second arg:" + int.Parse(input[i]));
#endif
                switch (input[i - 1].Substring(0,1))
                {
                    case "+":
#if (Debug)
                        Console.WriteLine("Calculate function - Case: + ");
#endif
                        output[count] = Convert.ToString(int.Parse(input[i - 2]) + int.Parse(input[i]));
#if(Debug)
                        Console.WriteLine("Calculate function - Result:" + int.Parse(output[count]));
#endif
                        count++;
                        break;

                    case "-":
#if (Debug)
                        Console.WriteLine("Calculate function - Case: + ");
#endif
                        output[count] = Convert.ToString(int.Parse(input[i - 2]) - int.Parse(input[i]));
#if(Debug)
                        Console.WriteLine("Calculate function - Result:" + int.Parse(output[count]));
#endif
                        count++;
                        break;

                    case "*":
#if (Debug)
                        Console.WriteLine("Calculate function - Case: + ");
#endif
                        output[count] = Convert.ToString(int.Parse(input[i - 2]) * int.Parse(input[i]));
#if(Debug)
                        Console.WriteLine("Calculate function - Result:" + int.Parse(output[count]));
#endif
                        count++;
                        break;

                    case "/":
#if (Debug)
                        Console.WriteLine("Calculate function - Case: + ");
#endif
                        output[count] = Convert.ToString(int.Parse(input[i - 2]) / int.Parse(input[i]));
#if(Debug)
                        Console.WriteLine("Calculate function - Result:" + int.Parse(output[count]));
#endif
                        count++;
                        break;

                }

            }

            return output;

        }
    }
}
