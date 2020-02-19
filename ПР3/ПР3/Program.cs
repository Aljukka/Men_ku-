using System;

namespace ПР3
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 1;
            double a = 1;
            double s = 0;
            double t = 0.00001;
            while (a>=t)
            {
                a = 1 / (i * (i + 2));
                s = s+a;
                i++;
            }
            Console.WriteLine(s);
        }
    }
}