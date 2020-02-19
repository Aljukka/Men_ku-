using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Zahlen : IKalkulator
    {
        private double a = 0;
        public double Factorial()
        {
            double f = 1;
            for(int i=1;i<=a;i++)
            {
                f *= i;
            }
            return f;
        }
        public double Grad(double b)
        {
            return Math.Pow(a, b);
        }
        public void Klar_A()
        {
            a=0;
        }
        public double Multiplizieren(double b)
        {
            return a*b;
        }
        public double Rest(double b)
        {
            return a%b;
        }
        public void Setzen_A(double a)
        {
            this.a=a;
        }
        public double Subtraktion(double b)
        {
            return a-b;
        }
        public double Summe(double b)
        {
            return a + b;
        }
        public double Trennung(double b)
        {
            return a/ b; 
        }
        public double Wurzel()
        {
            return Math.Sqrt(a);
        }
    }
}