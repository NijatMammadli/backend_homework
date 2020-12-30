using System;
using System.Collections.Generic;
using System.Text;

namespace hw_exceptions_1
{
    public class Person
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
        private int age;
        public int Age
        {
            get {
                return age;
                    }

          

            set
            {
                     if (value < 18)
                    {
                    try
                    {

                        //this.age = 18;
                        throw new PersonException("the input age is incorrect", value);
                    }
                    catch (PersonException ex)
                    {
                        Console.WriteLine($"{ex.K} is incorrect");
                    }
                }
                else
                {
                    this.age = value;
                    //this.Age = value;
                }
               
                                     
                }
            } 
        }
        
      
    }

