using System;

namespace hw_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IndexOutOfRangeException();
                throw new NullReferenceException();
                throw new ArgumentException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("1");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("2");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("3");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
