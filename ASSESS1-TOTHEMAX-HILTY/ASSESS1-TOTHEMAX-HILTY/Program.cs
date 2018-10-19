using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESS1_TOTHEMAX_HILTY
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many numbers will you enter?");
            int n = int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"What is number {i + 1}?");
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            
            Array.Sort(numberArray);

            Console.WriteLine($"The largest number is {numberArray[n-1]}");
        }
    }
}
