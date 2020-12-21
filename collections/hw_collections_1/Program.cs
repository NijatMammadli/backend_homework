using System;
using System.Collections;
using System.Collections.Generic;


namespace hw_collections_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("country name: ");
                string country = Console.ReadLine();

                Console.WriteLine("capital name: ");
                string capital = Console.ReadLine();

                countries.Add(country, capital);

            }

            SEARCH:
            Console.WriteLine("Please enter country name you want to get capital for it:");
            string search_c = Console.ReadLine();
            Console.WriteLine(countries.GetValueOrDefault(search_c));

            if (search_c == "all")
            {
                foreach (KeyValuePair<string, string> kvp in countries)
                {
                    Console.WriteLine(kvp);
                   
                }
            }

            Console.WriteLine();
            Console.WriteLine("Search again? y/n ");
            ConsoleKeyInfo response =  Console.ReadKey();

            if (response.Key == ConsoleKey.Y)
            {
                goto SEARCH;
            }

        }
    }
}
