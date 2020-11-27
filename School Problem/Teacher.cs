using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class Teacher : People
    {
        //Fields
        List<Course> course = new List<Course>();
        static int incr=0;
        int id;

        //Properties
        public List<Course> Courses {
            get { return course; }
            set { this.course = value; }
        }
        public int ID
        {
            get { return id; }
        }

        //methods
        public Teacher()
        {
            incr++;
            this.id = incr;
        }
        public Teacher(string Fname,string Lname,List<Course> crse):base(Fname,Lname)
        {
            incr++;
            this.id = incr;
            this.course = crse;
        }
        public override string ToString()
        {
            string temp= base.ToString()+"\nID:"+id+
                "\nCourses: \n";
            foreach(Course item in Courses)
            {
                temp += item.name + "\n";
            }
            return temp;
        }
    }
}
