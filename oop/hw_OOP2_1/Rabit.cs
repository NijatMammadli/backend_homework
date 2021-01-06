using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_1
{
    class Rabit : Animal
    {
        public override void GetInfo()
        {
            Console.WriteLine("this is rabit"); 

        }

        public override void Walk()
        {
            Console.WriteLine("rabit is running");
        }


    }
}
