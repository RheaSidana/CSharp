using System;
using System.Collections.Generic;
using System.Text;

namespace InternalPracticalQ1
{
    class RetirementFunds
    {
        Employee emp;
        int ageOfRetirment;
        public RetirementFunds(Employee myEmp,int age)
        {
            emp = myEmp;
            ageOfRetirment = age;
        }

        public double GrossFunds()
        {
            double amount = 0,tempSal,ySal,bonus ;
            tempSal = emp.Salary;
            for(int i = emp.Age; i <= ageOfRetirment; i++)
            {
                ySal = tempSal * 12;
                if ((ySal * 0.1) > 30000)
                    bonus = 30000;
                else bonus = ySal * 0.1;
                amount +=bonus;
                //Console.WriteLine("i=  " + i +"\t ySal="+ySal+ "\tAmount=" + amount);
                tempSal += (tempSal * 0.05);
            }
            return amount;
        }
    }
}
