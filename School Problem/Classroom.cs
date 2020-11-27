using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class Classrooms
    {
        //Fields
        public string name;
        public List<Student> students;
        //dictionary<teacher,subject>
        public Dictionary<Teacher,string> teachers;

        //Properties


        //Methods
        public void setClassroom(List<Classrooms> SchoolRooms,List<Teacher> SchoolTeachers,List<Student> SchoolStudents)
        {
            teachers = new Dictionary<Teacher, string>();
            students = new List<Student>();
            Console.WriteLine("Enter the following Classroom details: ");
            do
            {
                Console.Write("1.Name : ");
                name = Console.ReadLine();
                bool Flag=false;
                foreach(Classrooms room in SchoolRooms)
                {
                    if (room.name.Equals(name))
                    {
                        Flag = true;
                        break;
                    }
                }
                if (Flag)
                {
                    Console.WriteLine("Class already exists!!");
                }
                else break;
            } while (true);
            Console.WriteLine("Enter the Teacher's List of the classroom ");
            do
            {
                SchoolTeachers.ForEach(x => Console.WriteLine(x));
                Teacher subjectTeacher = new Teacher();
                string subject;
                int id,flag=0;
                char ans;
                Console.WriteLine("Enter the teacher id : ");
                id = Convert.ToInt32(Console.ReadLine());
                foreach(Teacher teach in SchoolTeachers)
                {
                    if (teach.ID == id)
                    {
                        flag = 1;
                        subjectTeacher = teach;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Invalid Teacher Id");
                }
                else
                {
                    do
                    {
                        bool res = true;
                        Console.WriteLine("Enter the subject: ");
                        subject = Console.ReadLine();
                        foreach (Course subj in subjectTeacher.Courses)
                        {
                            if (subj.name.Equals(subject))
                            {
                                res = false;
                                break;
                            }
                        }
                        if (res == false) break;
                        else Console.WriteLine("Invalid Subject");
                    } while (true);
                    teachers[subjectTeacher] = subject;
                }
                Console.WriteLine("Do you want to enter more Teachers");
                ans = Console.ReadLine()[0];
                if (ans == 'n' || ans == 'N') break;
            } while (true);
            Console.WriteLine("Enter the Student's list");
            do
            {
                char ans;
                int age,rollno,flag=0,classRollNo=students.Count;
                Console.WriteLine("Enter the age of the students");
                age = Convert.ToInt32(Console.ReadLine());
                SchoolStudents.ForEach(x =>
                {
                    if (x.Age == age && x.ClassRollNo==0) { Console.WriteLine(x); }
                });
                do {
                    Console.WriteLine("Enter the Enrollment Number: ");
                    rollno = Convert.ToInt32(Console.ReadLine());
                    foreach (Student x in SchoolStudents)
                    {
                        if (x.RollNo == rollno)
                        {
                            x.ClassRollNo = (classRollNo + 1);
                            students.Add(x);
                            Console.WriteLine("Student added");
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("Invalid Enrollment Number");
                    }
                    else break;
                } while (true);
                Console.WriteLine("Do you want to enter more students?(y/n)");
                ans = Console.ReadLine()[0];
                if (ans == 'n' || ans == 'N') break;
            } while (true);
        }

        public override string ToString()
        {
            string temp= "\nname: " + name + "\n Teachers : \n";
            foreach (KeyValuePair<Teacher, string> item in teachers)
            {
                temp+="Name: " + item.Key.FName + " " + item.Key.LName + " :: Subject: " + item.Value+"\n";
            }
            temp+="\n Students : \n";
            students.ForEach(y => { temp += (y.ToString() + " Class Roll no: " + y.ClassRollNo + "\n"); });
            return temp;
        }
    }
}
