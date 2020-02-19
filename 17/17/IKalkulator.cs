using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    interface IKalkulator
    {
        void Setzen_A(double a);
        void Klar_A();
        double Multiplizieren(double b);
        double Trennung(double b);
        double Summe(double b);
        double Subtraktion(double b);
        double Grad(double b);
        double Rest(double b);
        double Wurzel();
        double Factorial();
    }
}