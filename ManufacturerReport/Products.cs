using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacturer
{
    public class Products : Assets
    {
        string p_id;
        string p_name;
        static int i = 0;
        public string Id
        {
            get { return p_id; }
            //set { p_id = value; }
        }
        public string Name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        public Products()
        {
            i++;
            this.p_id ="PNO"+ i.ToString();
        }
    }
}