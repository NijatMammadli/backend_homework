using System;
using System.Collections.Generic;
using System.Text;

namespace hw_sinif
{
    public class Car : IDisposable
    {
        public int price;


       

        public void Dispose()
        {
            Console.WriteLine("cleaning");
        }
    }
}
