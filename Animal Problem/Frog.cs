using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProblem
{
    class Frog : Animal
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
            set { gender = value; }
        }

        //method
        public Frog() { }
        public Frog(int yr, string called, string gen)
        {
            this.age = yr;
            this.name = called;
            this.gender = gen;
        }
        public override void makesSound()
        {
            Console.WriteLine("Frog's Sound : Tret!! Tret!!");
        }
        public override void show()
        {
            Console.WriteLine("\nThe following are the Details of the Frog: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            makesSound();
        }
    }
}
