using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProblem
{
    class Tomcat : Cat
    {
        public override int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Gender
        {
            get { return gender; }
            //set { gender = value; }
        }

        //method
        public Tomcat()
        {
            this.gender = "Male";
        }
        public Tomcat(int yr, string called)
        {
            this.age = yr;
            this.name = called;
            this.gender = "Male";
        }
    }
}
