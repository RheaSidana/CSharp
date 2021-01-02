using System;
using System.Collections.Generic;
using System.Text;

namespace Funds
{
    class RetirementFunds
    {
        int ageOfRetirement;
        Employee emp;
        Company company;
        public RetirementFunds(Employee myEmp,Company myCompany,int age) 
        {
            emp = myEmp;
            company = myCompany;
            ageOfRetirement = age;
        }
        public double GrossFunds()
        {
            double amount=0,govt,tempShares,bonus,money=0;
            tempShares = company.Shares;
            for(int i = emp.Age; i <= ageOfRetirement; i++)
            {
                bonus = tempShares * 0.002 / 100; // 0.002% of shares
                amount += bonus;
                govt = amount * 0.01; // cummulative aid on shares
                money += bonus + govt; //total fund
                //amount += bonus + govt;
                //Console.WriteLine("i= " + i + " Bonus= " + bonus + "  govt= " + govt + "  Amount= " + amount+"  Money= "+money);
                tempShares += (tempShares * 0.05); //growth =5% of shares
            }
            return money;
        }
    }
}
