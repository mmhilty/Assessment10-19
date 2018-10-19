using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESS3_LISTONLISTONLIST_HILTY
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> stringList = new List<string>() { "maple", "beech", "cottonwood", "blue spruce", "slippery elm" };
            while (true)
            {
                

                Console.WriteLine(@"What would you like to do?
1. View full list
2. Search list
3. Sort list
4. Add to list
5. Quit");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    foreach (string tree in stringList)
                    {
                        Console.WriteLine(tree);
                    }
                }

                else if (userInput == "2")
                {
                    ///SEARCH FUNCTION 
                    searchFunction(stringList);
                }

                else if (userInput == "3")
                {
                    ///SORT FUNCTION 
                    stringList = sortFunction(stringList);
                }

                else if (userInput == "4")
                {
                    ///ADD FUNCTION 
                    stringList = addFunction(stringList);
                }

                else if (userInput == "5")
                {
                    break;
                }

                else {
                    Console.WriteLine("Not an option.");
                }


            }

            
        }
        // search function

        public static void searchFunction(List<string> stringList)

        {
            Console.WriteLine("What would you like to search for?");
            string userInput = Console.ReadLine();

            if (stringList.Contains(userInput))
            {
                Console.WriteLine($"Your list does contain {userInput}.");
            }
            else
            {
                Console.WriteLine($"Your list does not contain {userInput}.");
            }

        }


        // sort function

        public static List<string> sortFunction(List<string> stringList)
        {

            //  string[] stringArray = stringList.ToArray();
            stringList.Sort();
            return stringList;

        }


        // add function

        public static List<string> addFunction(List<string> stringList)
        {
            Console.WriteLine("What would you like to add to the list?");
            string userInput = Console.ReadLine();
            stringList.Add(userInput);
            return stringList;

        }
    }
}
