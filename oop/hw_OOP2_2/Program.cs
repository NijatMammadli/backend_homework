using System;
using System.Collections.Generic;

namespace hw_OOP2_2
{
    class Program
    {

        
        static void Main(string[] args)
        {

            
            Book book1 = new Book("Tolstoy", "Childhood", 1923);
            Book book2 = new Book("Jennifer Egan", "A Visit From the Goon Squad", 2010);
            Book book3 = new Book("Tea Obreht", "The Tiger's Wife", 2011);
            Book book4 = new Book("Elena Ferrante", "My Brilliant Friend", 2012);
            Book book5 = new Book("George Saunders", "Tenth of December", 2013);
            Book book6 = new Book("Claudia Rankine", "Citizen", 2014);
            List<Book> L1 = new List<Book>();
            L1.Add(book1);
            L1.Add(book2);
            L1.Add(book3);
            L1.Add(book4);
            L1.Add(book5);
            L1.Add(book6);


            Console.WriteLine("Please provide your name, lastname and age");
            string name = Console.ReadLine();
            string ln = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, ln, age);
            person.myFavoriteBook = book1;
            string det="";
            det.Print(person);

        }
       
      
    }
}
