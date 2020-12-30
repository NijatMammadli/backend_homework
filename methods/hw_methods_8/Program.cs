using System;

namespace hw_methods_8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWinner();

        }
        public static void GetWinner()
        {
            Random random_num = new Random();
            int a = random_num.Next(1, 10);
            Console.WriteLine(a);

            if (a < 5)
            {
                Console.WriteLine("Team1 qalib oldu!");
            }else if(a == 5)
            {
                Console.WriteLine("Hech heche");
            }
            else
            {
                Console.WriteLine("Team2 qalib oldu");
            }


        }
    }
}
