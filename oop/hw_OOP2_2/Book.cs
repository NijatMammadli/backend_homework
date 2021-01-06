using System;
using System.Collections.Generic;
using System.Text;

namespace hw_OOP2_2
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }

        
        
        
        public override string ToString()
        {
            string result =  $"\n Author: {Author}  Title: {Title}  Publish Year: {PublishYear}";
            return result;
            Console.WriteLine(result);
        }

        public Book(string author, string title, int publish)
        {
            this.Author = author;
            this.Title = title;
            this.PublishYear = publish;
        }
    }
}
