using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProblem
{
    abstract class Cat : Animal
    {
        public override int Age{get;set;}
        public override string Name{get;set;}
        public override string Gender{get;set;}

        //method
        public override void makesSound()
        {
            Console.WriteLine("Cat's Sound : Meow!! Meow!!");
        }
        public override void show()
        {
            Console.WriteLine("\nThe following are the Details of the Cat: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            makesSound();
        }
    }
}
