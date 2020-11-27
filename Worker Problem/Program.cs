using System;

namespace WorkerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student 
            Student s1 = new Student("Paakhi", "Sidana", 98);
            //using constructor
            Console.WriteLine("\n... Student Section ...\nUsing Constructor");
            Console.WriteLine(s1);
            s1 = new Student();
            //using properties
            Console.WriteLine("\n\nUsing Properties");
            s1.Fname = "Rhea";
            s1.Lname = "Sidana";
            s1.Mark = 97;
            Console.WriteLine(s1);

            //Worker
            Worker w1 = new Worker("Sonu", "Sidana", 2000, 30);
            //using constructor
            Console.WriteLine("\n... Worker Section ...\nUsing Constructor");
            Console.WriteLine(w1);
            w1 = new Worker();
            //using properties
            Console.WriteLine("\n\nUsing Properties");
            w1.Fname = "Reema";
            w1.Lname = "Sidana";
            w1.Wage = 1800;
            w1.HoursWorked = 30;
            Console.WriteLine(w1);
        }
    }
}
