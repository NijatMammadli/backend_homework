using System;

namespace HW_arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("10 eded daxil edin: ");
            int[] numbers = new int[10];
            
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
           
            foreach(var element in numbers)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
