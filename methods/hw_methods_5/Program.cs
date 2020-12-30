using System;

namespace hw_methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime dt2 = now.AddDays(-2).AddHours(1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt2.ToString("dd-MM-yyyy   HH:mm"));


        }
    }
}
