using System;

namespace hw_strings
{
    class Program
    {
        static void Main(string[] args)
        {
        Start_a:
            Console.WriteLine("insert a number with 3 digits:");

            string a = Console.ReadLine();
            if (a.Length != 3)
            {
                goto Start_a;
            }


        Start_b:
            Console.WriteLine("insert a number with 5 digits:");

            string b = Console.ReadLine();
            if (b.Length != 5)
            {
                goto Start_b;
            }

            string c = (a.Substring(0,2) + b.Substring(1,4));
            int number_int = Convert.ToInt32(c);
            string number_st = Convert.ToString(number_int);

            int first_3 = Convert.ToInt32(number_st.Substring(0, 3));
            int last_3 = Convert.ToInt32(number_st.Substring(3, 3));
            int result = last_3 - first_3;

            if(result < 0)
            {
                Console.WriteLine("difference is negative:");
                goto Start_a;
            }
            Console.WriteLine($"result is { result} \t");
            
            

        }
    }
}
