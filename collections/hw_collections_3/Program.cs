using System;
using System.Collections;
using System.Collections.Generic;

namespace hw_collections_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter 10 numbers as an input:");
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine($"input number {i + 1}");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            List<int> first_5 = numbers.GetRange(0, 5);
            List<int> last_5 = numbers.GetRange(5, 5);
            List<int> result = new List<int>();
            result.AddRange(last_5);
            result.AddRange(first_5);

            foreach(var element in result)
            {
                Console.WriteLine(element);
            }
        }
    }
}
