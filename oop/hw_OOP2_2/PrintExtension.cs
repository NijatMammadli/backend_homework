using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;



namespace hw_OOP2_2

{
    public static class PrintExtension
    {
        public static string Print(this String str, Person person)
        {
                        
            str = ($"\n Name: {person.FirstName}  LastName: {person.LastName}  Age: {person.Age} FavoriteBook: {person.myFavoriteBook.ToString()}");
            Console.WriteLine(str);
            return str;
            
        }
    }
}