using System;
using System.Collections.Generic;

namespace SchoolProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!.. School Question ..!!");
            School mySchool = new School();
            //adding school name 
            mySchool.Name = "Queen Mary's School, Rohini";

            //adding course
            List<Course> engCourseList = new List<Course>(); //english course
            Course myCourse = new Course();
            myCourse.name = "English_8";
            myCourse.count_of_Classes = 30;
            myCourse.count_of_Excercise = 10;
            //Console.WriteLine(myCourse);
            //myCourse.getCourse();
            //adding to list
            engCourseList.Add(myCourse);

            //creating new Course
            myCourse = new Course();
            myCourse.name = "English_7";
            myCourse.count_of_Classes = 32;
            myCourse.count_of_Excercise = 9;
            //adding to list
            engCourseList.Add(myCourse);

            //creating new Course
            myCourse = new Course();
            myCourse.name = "English_6";
            myCourse.count_of_Classes = 29;
            myCourse.count_of_Excercise = 8;
            //adding to list
            engCourseList.Add(myCourse);

            List<Course> mathsCourseList = new List<Course>(); //maths course
            myCourse = new Course();
            myCourse.name = "Maths_8";
            myCourse.count_of_Classes = 30;
            myCourse.count_of_Excercise = 10;
            //adding to list
            mathsCourseList.Add(myCourse);

            //creating new Course
            myCourse = new Course();
            myCourse.name = "Maths_7";
            myCourse.count_of_Classes = 32;
            myCourse.count_of_Excercise = 9;
            //adding to list
            mathsCourseList.Add(myCourse);

            //creating new Course
            myCourse = new Course();
            myCourse.name = "Maths_6";
            myCourse.count_of_Classes = 29;
            myCourse.count_of_Excercise = 8;
            //adding to list
            mathsCourseList.Add(myCourse);

            //adding Teachers in the school
            List<Teacher> teacherList = new List<Teacher>();
            Teacher engTeacher = new Teacher("Sapna","Gupta",engCourseList);
            //Console.WriteLine(engTeacher);
            teacherList.Add(engTeacher);
            Teacher mathsTeacher = new Teacher("Rakhi", "Sharma", mathsCourseList);
            teacherList.Add(mathsTeacher);

            mySchool.Teachers = teacherList; //teachers added to the school
            Dictionary<Teacher, string> teacherDictionary = new Dictionary<Teacher, string>();
            teacherDictionary[engTeacher] = "English_8";
            teacherDictionary[mathsTeacher] = "Maths_8";

            //adding Student in the school
            List<Student> studentsList = new List<Student>();
            Student Paakhi = new Student("Paakhi","Sidana",13,3);
            Student Sonu = new Student("Sonu", "Sidana", 13, 5);
            Student Rhea = new Student("Rhea", "Sidana", 13, 4);
            Student Mani = new Student("Mani", "Sharma", 13,2);
            Student Anya = new Student("Anya", "Gupta", 13, 1);
            //Console.WriteLine(Rhea);

            studentsList.Add(Anya);
            studentsList.Add(Mani);
            studentsList.Add(Paakhi);
            studentsList.Add(Rhea);
            studentsList.Add(Sonu);
            //studentsList.ForEach(x => Console.WriteLine(x));

            /*
            Rhea = new Student();
            Rhea.FName = "Rhea";
            Rhea.LName = "Kapoor";
            Rhea.Age = 12;
            */
            
            mySchool.Students = studentsList;  //students added

            //adding Classrooms in the school
            Classrooms myClassroom = new Classrooms();
            myClassroom.name = "8-G";
            myClassroom.students = studentsList;
            myClassroom.teachers = teacherDictionary;
            //Console.WriteLine(myClassroom);
            
            
            mySchool.Classes = new List<Classrooms>() { myClassroom };
            
            //checking for setClassroom()
            /*
            List<Student> list = new List<Student>();
            studentsList.ForEach(x =>
            {
                list.Add(x);
            });
            list.Add(Rhea);
            mySchool.Students = list;
            Classrooms newClass = new Classrooms();
            newClass.setClassroom( mySchool.Classes, mySchool.Teachers, mySchool.Students);
            mySchool.Classes.Add(newClass);
            */

            //displaying the details of the school according to the classes
            mySchool.showSchool();
            
        }
    }
}
