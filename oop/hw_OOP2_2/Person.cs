using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_2
{
    public  class Person
    {
        public string FirstName { get; set; }

        public Book myFavoriteBook { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string name, string last, int age)
        {
            this.FirstName = name;
            this.LastName = last;
            this.Age = age;
        }
    }

    

}
