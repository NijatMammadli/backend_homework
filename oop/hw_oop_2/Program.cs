using System;

namespace hw_oop_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Country<string> country = new Country<string>()
            {
                Name = "Azerbaijan",
                Capital = "Baku",
                population = 1000000,
                seaName ="Khazar"
                
            };



            Console.WriteLine($"{country.Name}\n  {country.Capital} {country.population} {country.seaName ?? "There is no sea"}");



        }
    }
}
