using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 5, 7, 2 };
            List<int> indices = new List<int>();
            var target = 9;
            for (int i = 0; i < numbers.Count; i++) 
            {
                var number = numbers[i];
                for (int j  = 0; j < numbers.Count; j++)
                {
                    var number2 = numbers[j];
                    if (number + number2 == target)
                    {
                        indices.Add(i);
                        indices.Add(j);
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