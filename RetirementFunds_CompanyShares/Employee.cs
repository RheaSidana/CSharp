using System;
using System.Collections.Generic;
using System.Text;

namespace Funds
{
    class Employee
    {
        int ageOfJoining;
        public int Age
        {
            get { return ageOfJoining; }
        }

        public Employee(int age)
        {
            ageOfJoining = age;
        }
    }
}
