using System;

namespace hw_oop_3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = 0;
                int y = 10;

                Console.WriteLine(y / x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }




           
        }
    }
}
