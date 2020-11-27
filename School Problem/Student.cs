using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class Student : People
    {
        //Fields
        //enrollment number
        static int rollNo=0;
        int enroll;
        int age;
        int classRollNo;

        //Properties
        public int RollNo
        {
            get { return enroll; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int ClassRollNo
        {
            get { return classRollNo; }
            set { classRollNo = value; }
        }

        //Methods
        public Student()
        {
            rollNo++;
            enroll = rollNo;
            classRollNo = 0;
        }
        public Student(string Fname,string Lname,int ages,int no):base(Fname,Lname)
        {
            rollNo++;
            this.enroll = rollNo;
            this.age = ages;
            this.classRollNo = no;
        }
        public override string ToString()
        {
            return ("\nEnrollment number: " + enroll + "   " + base.ToString()+"  ");
        }
    }
}
