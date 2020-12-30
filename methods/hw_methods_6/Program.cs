using System;

namespace hw_methods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1994,11,22);
            Console.WriteLine(birthday.ToString("Year : yyyy \n 'Month' : MM \n 'Day' : dd"));
            Console.WriteLine(AgeCalculator(birthday));
        }

        public static int AgeCalculator(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.Month < date.Month || DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)
            {
                age--;
            }
                return age;
        }
    }
}
