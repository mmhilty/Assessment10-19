using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESS4_2NDDIM_HILT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] squareArray = new int[4, 4]
            {{5,-4,3,0 },
             {5,1,-2,-1 },
             {8,6,-7,4 },
             {-2,1,-5,2 }
             };

            Console.WriteLine("Here is your 2D array:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(squareArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            List<int> diagList = ShowDiagonalNumbers(squareArray, 4);
            Console.Write($"All of the numbers that lie on the diagonal are "); 
            foreach (int n in diagList) { Console.Write($"{n} "); }
            Console.WriteLine("");
            Console.WriteLine($"The sum of all the diagonal numbers is {SumDiagonal(squareArray, 4)}");
            Console.WriteLine($"The sum of all the numbers in the array is {SumWholeArray(squareArray, 4)}");


        }


        public static List<int> ShowDiagonalNumbers(int[,] squareArray, int sideLength)
        {
            List<int> diagList = new List<int>();

            for (int i = 0; i < sideLength; i++)
            {
                diagList.Add(squareArray[i, i]);
            }

            return diagList;
        }

        public static int SumDiagonal(int[,] squareArray, int sideLength)

        {
            List<int> diagList = new List<int>();

            for (int i = 0; i < sideLength; i++)
            {
                diagList.Add(squareArray[i,i]);
            }

            return diagList.Sum();

        }

        public static int SumWholeArray(int[,] squareArray, int sideLength)
        {
            List<int> fullList = new List<int>();

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    fullList.Add(squareArray[i,j]);
                }
            }

            return fullList.Sum();
        }
    }
}
