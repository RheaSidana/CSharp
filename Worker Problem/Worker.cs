using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerProblem
{
    class Worker : Human
    {
        //data members
        double wage, hoursWorked; 

        //Prpoerties 
        //      base by default
        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        //Methods
        public Worker() { }
        public Worker(string first,string last,double money,double hr)
            : base(first, last)
        {
            this.wage = money;
            this.hoursWorked = hr;
        }
        public double calHourWage()
        {
            return (wage * hoursWorked);
        }

        public override string ToString()
        {
            double salary = calHourWage();
            return (base.ToString() + "\nHourly Wage: " + salary.ToString());
        }
    }
}
