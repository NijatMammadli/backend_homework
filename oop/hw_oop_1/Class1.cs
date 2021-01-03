using System;
using System.Collections.Generic;
using System.Text;

namespace hw_oop_1
{
   
    
        public enum UniversityStaff
        {
            Student =1,
            Teacher,
            Lecturer,
            Professor
        };



        public class Person
        {
            public string name;
                public string surname;
                public string fathers_name;
            public UniversityStaff role;
            
        }



    }
    
