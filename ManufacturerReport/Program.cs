using System;
using System.Collections.Generic;

namespace Manufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> myList = new List<Products>();
            /*while (true)
            {
                Products item = new Products();
                Console.WriteLine("Enter the Products Details: ");
                Console.WriteLine("Products Name: ");
                item.Name = Console.ReadLine();
                myList.Add(item);
                Console.WriteLine("Product added!");
                Console.WriteLine("Want to enter more?(y/n)");
                char ans = Console.ReadLine()[0];
                if (ans == 'n' || ans == 'N') break;
            }*/
            Products item = new Products();
            item.Name = "Towel";
            myList.Add(item);
            item = new Products();
            item.Name = "Soap";
            myList.Add(item);
            item = new Products();
            item.Name = "Shampoo";
            myList.Add(item);
            item = new Products();
            item.Name = "Conditioner";
            myList.Add(item);
            item = new Products();
            item.Name = "BodyWash";
            myList.Add(item);

            InventoryRecord report = new InventoryRecord(myList);

            Employee myEmp = new Employee();
            myEmp.Name = "Rhea";
            Employee myEmp2 = new Employee();
            myEmp2.Name = "Sonu";
            Employee myEmp3 = new Employee();
            myEmp3.Name = "Somya";

            Console.WriteLine("Now Entering the Products Produced today");
            
            //Products item = myList[myList.Count % 2];
            DateTime myDate = DateTime.Now.AddDays(-1);
            //Console.WriteLine("\nDate: " + myDate.ToString());

            report.getProduced(myEmp, (myList[0]), 3, myDate);
            report.getProduced(myEmp, (myList[myList.Count-1]), 3, myDate);
            //emp 6
            report.getProduced(myEmp2,(myList[2]), 4, myDate);
            //emp2 4
            report.getProduced(myEmp3, (myList[myList.Count-1]), 2, myDate);
            //emp3 2

            Console.WriteLine("\n\nDisplaying Yesterday's Report");
            report.DisplayDateReport(myDate);

            myDate = DateTime.Now.Date;
            //Console.WriteLine("\nDate: " + myDate);
            report.getProduced(myEmp, (myList[1]),4);
            //emp today 4
            report.getProduced(myEmp2, (myList[3]), 4);
            report.getProduced(myEmp2, (myList[2]), 2);
            //emp today 6
            report.getProduced(myEmp3, (myList[myList.Count - 1]), 3);
            //emp today 3
            

            Console.WriteLine("\n\nToday's Report");
            report.DisplayDateReport(myDate);

            Console.WriteLine("\n\nMonthly Report\n");
            report.DisplayMonthReport(myDate.Month);
        }
    }
}
