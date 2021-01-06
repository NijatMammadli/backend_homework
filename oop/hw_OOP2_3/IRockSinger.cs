using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_3
{
    interface IRockSinger : ISinger
    {
        public void SwingGuitar()
        {
            Console.WriteLine("Swinging guitar");
        }
    }
}
