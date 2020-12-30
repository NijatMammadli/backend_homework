using System;

namespace hw_methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            for(int i=0; i<4; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            ChangeNumbers(numbers);

            for(int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int[] ChangeNumbers(int[] numbers)
        {
            int[] numbers_2 = new int[4] { 2, 4, 6, 8 };
            for(int i=0; i<numbers_2.Length; i++)
            {
                numbers[i] = numbers_2[i];
            }
            
            return numbers;
        }


    }
}
