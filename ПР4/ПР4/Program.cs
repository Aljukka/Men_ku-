using System;

namespace ПР4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i=10; i<=99; i++)
            {
                int a = i / 10 % 10;
                int b = i % 10;
                int c=(a*b)*3;
                if (i==c)
                {
                    Console.WriteLine(i);
                }
            }*/
            for (int i=100; i<=999;i++)
            {
                int x = i % 7;
                if (x==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
