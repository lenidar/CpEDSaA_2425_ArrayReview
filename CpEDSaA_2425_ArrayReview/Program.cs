using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEDSaA_2425_ArrayReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uInput = "Southville International University";
            char[] chars = uInput.ToCharArray();

            //Console.WriteLine(uInput);
            //foreach(char c in uInput)
            //{
            //    Console.WriteLine(c);
            //}
            Console.WriteLine(uInput[7]);
            Console.WriteLine(chars[7]);

            for(int x = 0;  x < chars.Length; x++)
            {
                if(x % 2 == 0)
                {
                    if ((int)chars[x] >= 97)
                    {
                        chars[x] = (char)((int)chars[x] - 32);
                    }
                    else
                    {
                        chars[x] = (char)((int)chars[x] + 32);
                    }
                }
            }
            Console.WriteLine(uInput);
            foreach (char c in chars)
            {
                Console.Write(c);
            }

            Console.ReadKey();
        }
    }
}
