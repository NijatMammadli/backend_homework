using System;

namespace hw_methods_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToText();
            

        }
        public enum numbers
        {
            bir = 1,
            iki,
            uc,
            dord,
            besh,
            alti,
            yeddi,
            sekkiz,
            doqquz,
            on

        }
        public static void ConvertToText()
        {
        START:
            Console.WriteLine("Please provide number between 1 and 10");
            
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 1 || a > 10)
            {
                Console.WriteLine("number should be between 1 and 10");
                goto START;
            }



            string b = Enum.GetName(typeof(numbers), a);
            
            Console.WriteLine(b);
        }

    }
}
