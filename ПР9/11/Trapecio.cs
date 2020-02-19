using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public class Trapecio: Kvarangulo, IkolkulasArea
    {
        private double vysota;
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
        public Trapecio(double vysota, double a, double b, string imja):base(a,b)
        {
            this.vysota = vysota;
        }
        public double GetVysota()
        {
            return this.vysota;
        }
        public double KolkulasArea()
        {
            double s = (vysota * (a + b)) / 2;
            return s;
        }
    }
}
