using System;

namespace hw_OOP2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird eagle = new Bird();

            eagle.Walk();
            eagle.GetInfo();
            eagle.Eat();
            eagle.Fly();
        }
    }
}
