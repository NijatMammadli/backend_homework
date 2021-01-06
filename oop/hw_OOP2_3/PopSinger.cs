using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_3
{
     public class PopSinger: IPopSinger
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        

        
        public void RecordSong()
        {
            Console.WriteLine($"{Name} {LastName} Recording Pop song");
        }







        public PopSinger(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }

       
    }
}
