using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerProblem
{
    class Human
    {
        //data members
        string fname, lname;

        //Properties
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        //Methods 
        public Human() { }
        public Human(string first,string last) 
        {
            this.fname = first;
            this.lname = last;
        }

        public override string ToString()
        {
            return ("\nName: "+Fname+" "+Lname);
        }
    }
}
