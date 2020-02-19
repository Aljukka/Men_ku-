using System;

namespace ПР1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четырёхзначное число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите трёхзначное число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дробное число");
            double d = Convert.ToDouble(Console.ReadLine());
            bool z = Uberprufen1(a);
            bool y = Uberprufen2(b);
            bool x = Uberprufen3(c);
            bool w = Uberprufen4(d);
            Zeigen(z, y, x, w);
        }
        static bool Uberprufen1(int a)
        {
            bool z;
            int x = 0;
            int y = a;
            while(y>0)
            {
                x = x + y % 10;
                y = y / 10;
            }
            x = x * x * x;
            a = a * a;
            if (a==x)
            {
                z = true;
            }
            else 
            {
                z = false;
            }
            return z;
        }
        static bool Uberprufen2(int b)
        {
            bool y;
            int x = 0;
            int z = 0;
            int k = b;
            while(k>0)
            {
                x = x + k % 10;
                k = k / 10;
            }
            while(b>100)
            {
                z = z + b % 10;
                b = b / 10;
            }
            x = x - z;
            if (x==z)
            {
                y = true;
            }
            else
            {
                y = false;
            }
            return y;
        }
        static bool Uberprufen3(int c)
        {
            bool x;
            int n = c / 100 % 10;
            int m = c /10 % 10;
            int l = c % 10;
            if (n==m||m==l||l==n)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
        }
        static bool Uberprufen4(double d)
        {
            bool w;
            int n = Convert.ToInt32((d * 10) % 10);
            int m = Convert.ToInt32((d * 100) % 10);
            int l = Convert.ToInt32((d * 1000) % 10);
            if (n == 0 || m == 0 || l==0)
            {
                w = true;
            }
            else
            {
                w = false;
            }
            return w;
        }
        static void Zeigen(bool z, bool y, bool x, bool w)
        {
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(w);
        }
    }
}