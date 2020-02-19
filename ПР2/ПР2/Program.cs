using System;

namespace ПР2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double o = 1;
            double f = 1;
            for (double i = 1; i <= n; i++)
            {
                f = f * i;
                double u = (1 / f) + 2;
                o = o * u;
            }
            Console.WriteLine(o);
        }
    }
}
