using System;
using System.Collections.Generic;

namespace AnimalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating List of Different Animals
            List<Animal> animal = new List<Animal>();

            //creating Dog instance 
            Dog dog = new Dog(3,"Coco","Female");
            animal.Add(dog);

            dog = new Dog();
            dog.Age = 2;
            dog.Gender = "Male";
            dog.Name = "Jugs";
            //animal.Add(dog);

            //creating Frog instance
            Frog frog = new Frog(4, "Grumps", "Male");
            animal.Add(frog);

            frog = new Frog();
            frog.Age = 2;
            frog.Gender = "Female";
            frog.Name = "Owts";
            //animal.Add(frog);

            //Creating Kitten and Tomcat 
            Cat cat = new Kitten(2,"Kitty");
            animal.Add(cat);

            cat = new Kitten();
            cat.Age = 3;
            cat.Name = "Beom";
            animal.Add(cat);

            cat = new Tomcat(4, "Tom");
            animal.Add(cat);

            cat = new Tomcat();
            cat.Age = 6;
            cat.Name = "heya";
            //animal.Add(cat);

            animal.Add(frog);
            animal.Add(cat);
            animal.Add(dog);

            Console.WriteLine("Displaying the List of Animals");
            animal.ForEach(x => x.show());
        }
    }
}
