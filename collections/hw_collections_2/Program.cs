using System;
using System.Collections;
using System.Collections.Generic;

namespace hw_collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Please enter message: ");
            for(int i=0; i<10; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }

        Ask_again:
            Console.WriteLine("do you want to add more? y/n");
            string response = Console.ReadLine();

            if (response == "y")
            {
                queue.Dequeue();
                Console.WriteLine("give the message");
                queue.Enqueue(Console.ReadLine());
                goto Ask_again;
            }
            else if (response == "n")
            {
                goto Result;
            }



            Result:
            foreach (var elem in queue)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
