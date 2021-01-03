using System;
using System.Collections.Generic;
using System.Text;

namespace hw_oop_2
{
    public class Country<T>
    {

        public T seaName;
        public string Name;
        public string Capital;
        public int population;

        public Country(int population, string Name, string Capital, T seaName)
        {
            this.population = population;
            this.Name = Name;
            this.Capital = Capital;
            this.seaName = seaName;
        }

        public Country()
        {


        }


    }
}  

