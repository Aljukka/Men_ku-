using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public class Kvadrato: Kvarangulo, IkolkulasArea
    {
        private string mImja;
        string IkolkulasArea.Imja
        {
            get
            {
                return mImja;
            }
            set
            {
                mImja = value;
            }
        }
        public Kvadrato(double a, double b, string imja):base(a, b)
        {
            
        }
        public double KolkulasArea()
        {
            double s = a * a;
            return s;
        }
    }
}
