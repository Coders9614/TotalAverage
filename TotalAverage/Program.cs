using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalAverage
{
    internal class Program
    {
        static void CalculateTotalAndAverage(double[] numbers)
        {
            double total = 0;
            foreach (var num in numbers)
            {
                total += num;
            }

            double average = total / numbers.Length;

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
        }

        static void Main()
        {
            double[] inputNumbers = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter the {i + 1} number: ");
                inputNumbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            CalculateTotalAndAverage(inputNumbers);
            Console.ReadKey();
        }
    }
}
