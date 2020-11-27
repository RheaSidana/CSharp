using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProblem
{
    class People
    {
        //fields
        string first_name;
        string last_name;

        //Properties
        public string FName{
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }

        public string LName
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        //Methods
        public People() { }
        public People(string First,string Last)
        {
            FName = First;
            LName = Last;
        }
        //overriding ToString method
        public override string ToString()
        {
            return ("Name: "+FName+" "+LName);
        }
    }
}
