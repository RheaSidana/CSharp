using System;

namespace InternalPracticalQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee myEmp = new Employee(15000.0,25);
            RetirementFunds funds = new RetirementFunds(myEmp, 60);
            Console.WriteLine("Gross Funds: "+Math.Round(funds.GrossFunds(),1));
            */

            int age;
            double sal;
            //Console.WriteLine("Enter the salary : ");
            sal = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the age of joining : ");
            age =Convert.ToInt32(Console.ReadLine());
            Employee myEmp = new Employee(sal, age);
            //Console.WriteLine("Enter the age of retirement : ");
            age = Convert.ToInt32(Console.ReadLine());
            RetirementFunds funds = new RetirementFunds(myEmp, age);
            Console.WriteLine("\n" + Math.Round(funds.GrossFunds(), 1));
        }
    }
}
