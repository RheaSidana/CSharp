using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerProblem
{
    class Student : Human
    {
        //data members
        int mark;
        
        //Properties
        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        //Methods
        public Student() { }
        public Student(string first,string last,int no) :base(first,last)
        {
            this.mark = no;
        }

        public override string ToString()
        {
            return (base.ToString()+"\nMarks: "+Mark);
        }
    }
}
