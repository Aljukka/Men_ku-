using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public class Triangulo: IkolkulasArea
    {
        private double v;
        private double s;
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
        public Triangulo(double v, double s, string imja)
        {
            this.v = v;
            this.s = s;
        }
        public double GetV()
        {
            return this.v;
        }
        public double GetS()
        {
            return this.s;
        }
        public double KolkulasArea()
        {
            double sa = (v * s) / 2;
            return sa;
        }
    }
}
