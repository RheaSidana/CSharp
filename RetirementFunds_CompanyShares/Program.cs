using System;

namespace InternalPracticalQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company myCompany = new Company(20200000);
            Employee myEmp = new Employee(25);
            RetirementFunds funds = new RetirementFunds(myEmp, myCompany, 60);
            Console.WriteLine("\n\tGross Funds : " + Math.Round(funds.GrossFunds(),3));
        }
    }
}
