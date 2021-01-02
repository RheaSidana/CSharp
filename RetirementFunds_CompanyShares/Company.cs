using System;
using System.Collections.Generic;
using System.Text;

namespace InternalPracticalQ2
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
