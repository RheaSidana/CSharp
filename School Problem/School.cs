using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class School
    {
        //Fields
        string name;
        List<Classrooms> classes=new List<Classrooms>();
        List<Teacher> schoolTeachers=new List<Teacher>();
        List<Student> schoolStudents=new List<Student>();

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Classrooms> Classes
        {
            get { return classes; }
            set { classes = value; }
        }
        public List<Student> Students
        {
            get { return schoolStudents; }
            set { schoolStudents = value; }
        }
        public List<Teacher> Teachers
        {
            get { return schoolTeachers; }
            set { schoolTeachers = value; }
        }

        //Methods
        public void setClasses()
        {
            do
            {
                char ans;
                Classrooms classroom = new Classrooms();
                classroom.setClassroom(classes,schoolTeachers,schoolStudents);
                classes.Add(classroom);
                Console.WriteLine("Do you want to enter more classes?(y/n)");
                ans = Console.ReadLine()[0];
                if (ans == 'n' || ans == 'N') break;
            } while (true);
        }
        public void addTeacher()
        {
            //name and list of courses
            Teacher temp = new Teacher();
            char resp;
            List<Course> subjects=new List<Course>();
            Console.WriteLine("Enter the following details of the Teacher");
            Console.Write("First Name : ");
            temp.FName = Console.ReadLine();
            Console.Write("Last Name : ");
            temp.LName = Console.ReadLine();
            Console.WriteLine("Enter the List of Courses: ");
            do
            {
                char ans;
                Course sub = new Course();
                sub.getCourse();
                subjects.Add(sub);
                Console.WriteLine("Do you want to Enter more courses?(y/n)");
                ans = Console.ReadLine()[0];
                if (ans == 'n' || ans == 'N') break;
            } while (true);
            temp.Courses = subjects;
            Console.WriteLine("The following is the Teacher's details: \n"+temp);
            Console.WriteLine("Do you want to add the Teacher?(y/n)");
            resp = Console.ReadLine()[0];
            if (resp == 'y' || resp == 'Y')
            {
                schoolTeachers.Add(temp);
                Console.WriteLine("Teacher added successfully!!");
            }
            else Console.WriteLine("Teacher not Added");
        }
        public void addStudent()
        {
            //name age
            Student temp = new Student();
            char resp;
            Console.WriteLine("Enter the following details of the Student");
            Console.Write("First Name : ");
            temp.FName = Console.ReadLine();
            Console.Write("Last Name : ");
            temp.LName = Console.ReadLine();
            Console.Write("Age: ");
            temp.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The following is the Student's details: \n" + temp);
            Console.WriteLine("Do you want to add the Student?(y/n)");
            resp = Console.ReadLine()[0];
            if(resp=='y' || resp == 'Y')
            {
                schoolStudents.Add(temp);
                Console.WriteLine("Student added successfully!!");
            }
            else Console.WriteLine("Student not Added");
        }
        public override string ToString()
        {
            return ("The following are the details of the School :\nName: "+Name
                +"\nTotal number of classes: "+classes.Count
                +"\nTotal number of students: "+schoolStudents.Count
                +"\nTotal number of teachers: "+schoolTeachers.Count);
        }

        public void showSchool()
        {
            Console.WriteLine("The following are the details of the School :\nName: " + Name
                + "\nTotal number of classes: " + classes.Count
                + "\nTotal number of students: " + schoolStudents.Count
                + "\nTotal number of teachers: " + schoolTeachers.Count);
            Console.WriteLine("Classrooms:");
            classes.ForEach(x =>
            {
                Console.WriteLine(x);
                /*
                Console.WriteLine("name: "+x.name+"\n Teachers : ");
                foreach(KeyValuePair<Teacher,string> item in x.teachers)
                {
                    Console.WriteLine("Name: " + item.Key.FName + " " + item.Key.LName + " :: " + item.Value);
                }
                Console.WriteLine("\n Students : ");
                x.students.ForEach(y => Console.WriteLine(y+" Class Roll no: "+y.ClassRollNo));*/
            });
        }
    }
}
