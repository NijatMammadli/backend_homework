using System;

namespace hw_methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            ChangeNumber(a);
            
            
        }

        public static void ChangeNumber(int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
    }
}
