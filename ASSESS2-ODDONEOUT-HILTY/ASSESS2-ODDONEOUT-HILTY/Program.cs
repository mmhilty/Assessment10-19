using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESS2_ODDONEOUT_HILTY
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number greater than 0.");
            int n = int.Parse(Console.ReadLine());

            List<int> oddList = new List<int>();

            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }


            Console.WriteLine($"The sum of all the odd numbers between 1 and {n} is {sumMethod(oddList)}.");
            Console.WriteLine($"The average of all the odd numbers between 1 and {n} is {avgMethod(oddList)}.");

        }

        public static int sumMethod(List<int> numList)
        {
            return numList.Sum();

        }

        public static double avgMethod(List<int> numList)
        {
            return numList.Average();
        }



    }
}
