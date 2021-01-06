using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_3
{
   public interface ISinger
    {
         void Sing()
        {
            Console.WriteLine("Singing....");
        }

         void RecordSong();
    }
}
