using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public abstract class Kvarangulo
    {
        protected double a;
        protected double b;
        public Kvarangulo(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double GetA()
        {
            return this.a;
        }
        public double GetB()
        {
            return this.b;
        }
    }
}
