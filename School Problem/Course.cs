using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class Course
    {
        //Fields
        public string name;
        public int count_of_Classes, count_of_Excercise;

        //methods
        public void getCourse()
        {
            Console.WriteLine("Enter the following : ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Count of Classes: ");
            count_of_Classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count of Excercises: ");
            count_of_Excercise = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            string temp="\nCourse Details:";
            temp += "\nCourse Name: " + name;
            temp += "\nCount of Classes: " + count_of_Classes;
            temp += "\nCount of Excercise: " + count_of_Excercise+"\n";
            return temp;
        }
    }
}
