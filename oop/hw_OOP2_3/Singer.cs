using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_3
{
    public class Singer: ISinger
    {
        public string Name { get; set; }
        public string LastName
        {
            get; set;
        }

        public void RecordSong()
        {
            Console.WriteLine($"{Name} {LastName} Recording song"); 
        }

        public Singer(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }

      
    }
}
