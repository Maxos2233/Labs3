using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class ConsoleApp1
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, -6, -7, 2, -3 };
            var product = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                product *= numbers[i];
            }

            var signFunc = 0;
            if (product > 0)
            {
                signFunc = 1;
            }
            else if (product < 0)
            {
                signFunc = -1;
            }
            else
            {
                signFunc = 0;
            }

            Console.WriteLine(signFunc);
            Console.WriteLine(product);
        }
    }
}