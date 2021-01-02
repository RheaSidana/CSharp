using System;
using System.Collections.Generic;
using System.Text;

namespace Funds
{
    class Employee
    {
        double salary;
        int ageOfJoining;
        public int Age
        {
            get { return ageOfJoining; }
        }
        public double Salary
        {
            get { return salary; }
        }
        public Employee(double sal,int age)
        {
            if (sal < 15000)
                salary = 15000;
            else
                salary = sal;
            ageOfJoining = age;
        }
    }
}
