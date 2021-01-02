using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacturer
{
    public class Employee : Assets
    {
        string e_id;
        string e_name;
        static int i = 0;
        public string Id
        {
            get { return e_id; }
            //set { e_id = value; }
        }
        public string Name
        {
            get { return e_name; }
            set { e_name = value; }
        }
        public Employee()
        {
            i++;
            this.e_id = "ENO" + i.ToString();
        }
    }
}