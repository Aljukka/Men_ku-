using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public class Cirklo : IkolkulasArea
    {
        private double radius;
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
        public Cirklo(string imja, double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public double KolkulasArea() 
        {
            double s = (radius * radius) * 3.14;
            return s;
        }
    }
}
