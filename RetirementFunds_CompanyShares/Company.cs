using System;
using System.Collections.Generic;
using System.Text;

namespace Funds
{
    class Company
    {
        double currentAssets;
        public double Shares
        {
            get { return currentAssets; }
        }
        public Company(double shares)
        {
            currentAssets = shares;
        }
    }
}
