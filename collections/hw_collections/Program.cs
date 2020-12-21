using System;
using System.Collections;
using System.Collections.Generic;


namespace hw_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();


            for(int i=0; i<10; i++)
            {
                Console.WriteLine($"give number { i + 1}");
                hashSet.Add(Convert.ToInt32(Console.ReadLine()));

            }

            List<int> list_2 = new List<int>();
            list_2.AddRange(hashSet);
            list_2.Sort();
            foreach(var elem in list_2)
            {
                Console.WriteLine(elem);
            }
            
        }
    }
}
