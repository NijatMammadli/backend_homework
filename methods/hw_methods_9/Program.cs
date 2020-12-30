using System;

namespace hw_methods_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Change(ref a);
            Console.WriteLine(a);
        }


        public static void Change(ref int a)
        {
            a = a + 5;
        }
    }
}
