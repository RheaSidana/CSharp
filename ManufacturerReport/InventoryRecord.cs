using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacturer
{
    public class InventoryRecord
    {
        List<Products> myProducts;
        Dictionary<Employee, Dictionary<DateTime,Dictionary<Products,int>>> EmployeeProduced;
        //constructor
        public InventoryRecord(List<Products> myList)
        {
            myProducts = myList;
            EmployeeProduced = new Dictionary<Employee, Dictionary<DateTime,Dictionary<Products,int>>>();
        }
        //add product's qty produced by the Employee daily
        public void getProduced(Employee emp,Products item,int qty)
        {
            DateTime today =DateTime.Now.Date;
            if (EmployeeProduced.ContainsKey(emp) == true)
            {
                Dictionary<DateTime, Dictionary<Products, int>> DateProduct = EmployeeProduced[emp];
                if (EmployeeProduced[emp].ContainsKey(today) == true)
                {
                    Dictionary<Products, int> productQty = DateProduct[today];
                    productQty[item] = qty;
                }
                else
                {
                    Dictionary<Products, int> productQty = new Dictionary<Products, int>();
                    productQty[item] = qty;
                    DateProduct[today] = productQty;
                }
            }
            else
            {
                Dictionary<Products, int> productQty = new Dictionary<Products, int>();
                productQty[item] = qty;
                Dictionary<DateTime, Dictionary<Products, int>> DateProduct = new Dictionary<DateTime, Dictionary<Products, int>>();
                DateProduct[today] = productQty;
                EmployeeProduced[emp] = DateProduct;
            }
        }
        //overloading 
        public void getProduced(Employee emp, Products item, int qty,DateTime today)
        {
            //DateTime today = DateTime.Now.Date;
            if (EmployeeProduced.ContainsKey(emp) == true)
            {
                Dictionary<DateTime, Dictionary<Products, int>> DateProduct = EmployeeProduced[emp];
                if (EmployeeProduced[emp].ContainsKey(today) == true)
                {
                    Dictionary<Products, int> productQty = DateProduct[today];
                    productQty[item] = qty;
                }
                else
                {
                    Dictionary<Products, int> productQty = new Dictionary<Products, int>();
                    productQty[item] = qty;
                    DateProduct[today] = productQty;
                }
            }
            else
            {
                Dictionary<Products, int> productQty = new Dictionary<Products, int>();
                productQty[item] = qty;
                Dictionary<DateTime, Dictionary<Products, int>> DateProduct = new Dictionary<DateTime, Dictionary<Products, int>>();
                DateProduct[today] = productQty;
                EmployeeProduced[emp] = DateProduct;
            }
        }

        //display daily Report of Products produced by the Employee on a Particular date and total this month
        public void DisplayDateReport(DateTime today)
        {
            //DateTime today = DateTime.Now.Date;
            //Console.WriteLine("Calling Today ");
            int thisDay, thisMonth;
            foreach(KeyValuePair<Employee, Dictionary<DateTime, Dictionary<Products, int>>> emp in EmployeeProduced)
            {
                thisDay = thisMonth = 0;
                foreach(KeyValuePair<DateTime, Dictionary<Products, int>> dateItem in emp.Value)
                {
                    if (dateItem.Key == today)
                    {
                        foreach(KeyValuePair<Products, int> item in dateItem.Value)
                        {
                            thisDay += item.Value;
                        }
                    }
                    if (dateItem.Key.Month == today.Month)
                    {
                        foreach (KeyValuePair<Products, int> item in dateItem.Value)
                        {
                            thisMonth += item.Value;
                        }
                    }
                }
                Console.WriteLine("Employee Id : " + emp.Key.Id + " Produces " + thisDay + " today and " + thisMonth + " Total");
            }
        }
        //display monthly Report
        public void DisplayMonthReport(int month)
        {
            Console.WriteLine("PRODUCT'S REPORT");
            getProductsReport(month);
            Console.WriteLine("\nEMPLOYEE'S REPORT");
            getEmployeeProducedReport(month);
        }
        //displays Product's month summary 
        void getProductsReport(int month)
        {
            Dictionary<Products, int> items = new Dictionary<Products, int>();
            foreach(KeyValuePair<Employee, Dictionary<DateTime, Dictionary<Products, int>>> empDateProd in EmployeeProduced)
            {
                Dictionary<DateTime, Dictionary<Products, int>> DateProd=empDateProd.Value;
                foreach(KeyValuePair<DateTime, Dictionary<Products, int>> DateItem in DateProd)
                {
                    if (DateItem.Key.Month == month)
                    {
                        Dictionary<Products, int> prod = DateItem.Value;
                        foreach(KeyValuePair<Products,int> myItem in prod)
                        {
                            if (items.ContainsKey(myItem.Key))
                                items[myItem.Key] = items[myItem.Key] + myItem.Value;
                            else
                                items[myItem.Key] = myItem.Value;
                        }
                    }
                }
            }
            DisplayProducts(items);
        }
        //displaying Products
        void DisplayProducts(Dictionary<Products,int> items)
        {
            foreach(KeyValuePair<Products,int> item in items)
            {
                Console.WriteLine("Product Id : " + item.Key.Id + "  Product Name : " + item.Key.Name + "  Production : "+item.Value);
            }
        }
        //displays Employee's monthly Production of the products
        void getEmployeeProducedReport(int month)
        {
            Dictionary<Employee, Dictionary<DateTime, Dictionary<Products, int>>>.KeyCollection Emp = EmployeeProduced.Keys;
            //Dictionary<Employee, Dictionary<DateTime, Dictionary<Products, int>>>.ValueCollection DateProd = EmployeeProduced.Values;
            Dictionary<Products, int> items = new Dictionary<Products, int>();
            foreach(Employee emp in Emp)
            {
                Dictionary<DateTime, Dictionary<Products, int>> DateProd = EmployeeProduced[emp];
                foreach(KeyValuePair<DateTime, Dictionary<Products, int>> prod in DateProd)
                {
                    if (prod.Key.Month == month)
                    {
                        foreach(KeyValuePair<Products, int> x in prod.Value)
                        {
                            if (items.ContainsKey(x.Key))
                            {
                                items[x.Key] = items[x.Key] + x.Value;
                            }
                            else
                            {
                                items[x.Key] = x.Value;
                            }
                        }
                    }
                }
                Console.WriteLine("Employee Id : "+emp.Id+"  Employee Name : "+emp.Name);
                DisplayProducts(items);
                items.Clear();
                Console.WriteLine();
            }
        }
    }
}