using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_1
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("is eating");
        }

        public virtual void Walk()
        {
            Console.WriteLine("is walking");
        }

        public abstract void GetInfo();
           
    }
        
}
