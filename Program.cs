using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - Binary Search Integer");
            Console.WriteLine("[2] - Binary Search String");
            Console.WriteLine("Please select number: ");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    BinarySearchInteger();
                    break;
                case "2":
                    BinarySearchString();
                    break;
                default:
                    Console.WriteLine("Bye bye");
                    break;
            }
        }

        public static void BinarySearchInteger()
        {
            Console.WriteLine("Please enter some integer, separate by space: ");
            string input = Console.ReadLine();

            int[] data = input.Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            while (true)
            {
                Console.WriteLine("\nPlease enter number you want to find: ");
                input = Console.ReadLine();

                if (input == "")
                    break;

                try
                {
                    int found = BT.BinarySearch(data, Convert.ToInt32(input));

                    if (found < 1)
                        Console.WriteLine("item {0} not found", input);
                    else
                        Console.WriteLine("item {0} found at position {1}", input, found);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void BinarySearchString()
        {
            Console.WriteLine("Please enter some string, separate by space: ");
            string input = Console.ReadLine();

            string[] data = input.Split(' ');

            while (true)
            {
                Console.WriteLine("\nPlease enter string you want to find: ");
                input = Console.ReadLine();

                if (input == "")
                    break;

                try
                {
                    int found = BT.BinarySearch(data, input);

                    if (found < 1)
                        Console.WriteLine("item {0} not found", input);
                    else
                        Console.WriteLine("item {0} found at position {1}", input, found);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
