using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2Ques2
{
    class Dog : Animal
    {
        //Properties
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
        public Dog() { }
        public Dog(int yr, string called,string gen)
        {
            this.age = yr;
            this.name = called;
            this.gender = gen;
        }
        public override void makesSound()
        {
            Console.WriteLine("Dog's Sound : Bhow!! Bhow!!");
        }
        public override void show()
        {
            Console.WriteLine("\nThe following are the Details of the Dog: ");
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            makesSound();
        }
    }
}