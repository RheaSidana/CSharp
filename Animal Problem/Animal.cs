using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProblem
{
    abstract class Animal : IAnimalSound
    {
        //fields
        protected int age;
        protected string name,gender;
        
        //properties
        public abstract int Age { get; set; }
        public abstract string Name { get; set; }
        public abstract string Gender { get; set; }

        //methods
        public virtual void makesSound() { }
        public abstract void show();
    }
}
