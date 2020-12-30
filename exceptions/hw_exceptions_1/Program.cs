using System;

namespace hw_exceptions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            Console.WriteLine("Please provide name and age: ");
            p1.Name = Console.ReadLine();
            p1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p1.Age);
        }
    }
}
