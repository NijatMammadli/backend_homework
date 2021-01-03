using System;
using System.Collections.Generic;
using System.Collections;
using hw_oop_1;

namespace hw_oop_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
        START:
            Console.WriteLine("Please enter your name: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            p1.surname = Console.ReadLine();
            Console.WriteLine("Please enter your father's name: ");
            p1.fathers_name = Console.ReadLine();


            UniversityStaff your_r = UniversityStaff.Student;

            Console.WriteLine("Please select your role: 1 for student, 2 for Teacher, 3 for Lecturer, 4 for Professor ");
            int rol_n = Convert.ToInt32(Console.ReadLine());
            TimeSpan hourMinute = DateTime.Now.TimeOfDay;
            string greetingWord = "";
            if (hourMinute >= new TimeSpan(8, 0, 0) && hourMinute <= new TimeSpan(12, 0, 0))
            {
                greetingWord = "Good Morning";
            }
            else if(hourMinute > new TimeSpan(12, 0, 0) && hourMinute <= new TimeSpan(19, 0, 0))
                {
                greetingWord = "Good Afternoon";
            }
            else
            {
                greetingWord = "Good Evening";
            }



                switch (rol_n)
            {
                case 1:
                    p1.role = UniversityStaff.Student;
                    Console.WriteLine($"Welcome to our university {p1.name} {p1.surname} {p1.fathers_name}");
                    break;
                case 2:
                    p1.role = UniversityStaff.Teacher;
                    Console.WriteLine($"Our university is the best place for self-developing you as a teacher");
                    break;
                case 3:
                    p1.role = UniversityStaff.Lecturer;
                    Console.WriteLine($"Welcome back, {p1.name} ! Students are waiting for your lectures :");
                    break;
                case 4:
                    p1.role = UniversityStaff.Professor;
                    Console.WriteLine($"{greetingWord}  Professor");
                    break;




            }
            Console.WriteLine("give ag");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                goto START;
            }

        }
    }
}

