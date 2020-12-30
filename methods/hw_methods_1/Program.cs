using System;
using System.Collections.Generic;
using System.Collections;

namespace hw_methods_1
{
    class Program
    {
        

        static void Main(string[] args)
        {

            char character = 'a';

            Console.WriteLine("Please enter 3 words");


            List<String> words = new List<string>();
        AddingWords:
            for (int i = 0; i < 3; i++)
            {
                words.Add(Console.ReadLine());
            }

            Console.WriteLine("do you want to add another 3 words? y/n");


            if (Console.ReadKey().Key ==ConsoleKey.Y)
            {
                goto AddingWords;
            }
                      
                
        
    
            Console.WriteLine("Please give the character you want to find or press  '~' ");
            if (Console.ReadKey().Key == ConsoleKey.Oem3)
            {
                character = 'y';
               
            }
            else
            {
                //character = Convert.ToChar(Console.ReadLine());
                character = (Console.ReadKey().KeyChar);


            }

            
            int[] numbers = new int[words.Count];
            
           
           for(int i =0; i< words.Count; i++)
            {
                
               int count = words[i].GetLetterCount(character);
                numbers[i] = count;
                Console.WriteLine($"{words[i]}  -  {count} ");
                
                


            }
            int result = Sum(numbers);
            Console.WriteLine(result);
            




        }
       









        public static void Print(string w)
        {
            Console.WriteLine(w);
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum = sum + i;
                
            }

            return sum;
                                   
        }
      
       
        
    }
}
