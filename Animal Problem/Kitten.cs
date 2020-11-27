using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProblem
{
    class Kitten : Cat
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
        public Kitten() 
        {
            this.gender = "Female";
        }
        public Kitten(int yr, string called)
        {
            this.age = yr;
            this.name = called;
            this.gender = "Female";
        }
    }
}
