using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm1
{
    public class Calculus
    {
        public double polycal(double va, double[] iva)
        {
            double rslt = iva[0];
            for(int i=1; i < 10; i++)
            {
                rslt *= va;
                rslt += iva[i];
            }
            return rslt;
        }
    }
}