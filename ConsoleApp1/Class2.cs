using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class App
    {
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
        }
}
