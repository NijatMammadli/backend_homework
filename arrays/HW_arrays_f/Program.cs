using System;

namespace HW_arrays_f
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("10 muxtelif reqem daxil edin: ");
            int musbet = 0;
            int menfi = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] < 0)
                {
                    menfi++;
                }
                else if (numbers[i] > 0)
                {
                    musbet++;
                }
            }
            Console.WriteLine($"menfi: {menfi}");
            Console.WriteLine($"musbet: {musbet}");
        }
    }
}
