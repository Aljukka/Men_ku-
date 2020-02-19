using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public class Ortangulo : Kvarangulo, IkolkulasArea
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
        public Ortangulo(double a, double b, string imja) : base(a,b)
        { }
        public double KolkulasArea()
        {
            double s = a * b;
            return s;
        }
    }
}
