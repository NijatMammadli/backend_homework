using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_3
{
    public interface IPopSinger : ISinger
    {
         void GoMoonWalk()
        {
            Console.WriteLine("Going moonwalk");
        }
    }
}
