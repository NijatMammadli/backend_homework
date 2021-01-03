using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_1
{
    class Bird : Animal
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is bird"); 
        }

        public override void Walk()
        {
            Console.WriteLine("Bird is jumping");
        }

        public  void Fly()
        {
            Console.WriteLine("Bird is flying");
        }

     
    }
}
