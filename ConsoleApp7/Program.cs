using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 7, 11, 15 };
            List<int> indices = new List<int>();
            var target = 9;
            for (int i = 0; i < numbers.Count; i++) 
            {
                var number = numbers[i];
                foreach (int j in numbers)
                {
                    if (number + j == target)
                    {
                        indices.Add(numbers.IndexOf(number));
                        indices.Add(numbers.IndexOf(j));
                    }
                        

                }
                if (indices.Count == 2)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", indices));
            Console.ReadKey();
        }

    }

}