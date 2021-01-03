using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace hw_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = null;
            //try
            //{
            //    car = new Car();
            //}
            //finally
            //{
            //    if (car != null)
            //    {
            //        car.Dispose();
            //    }


            //}

            //using (Car car_2 = new Car())
            //{

            //}

            try
            {
                throw new IndexOutOfRangeException();
                throw new NullReferenceException();
                throw new ArgumentException();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("1");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch(NullReferenceException ex) 
            {

                Console.WriteLine("2");
                Console.WriteLine(ex.Message);
                throw;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("3");
                Console.WriteLine(ex.Message);
                throw;
            }

            
            

        }
    }
}
