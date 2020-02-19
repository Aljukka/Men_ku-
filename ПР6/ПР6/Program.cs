using System;

namespace ПР6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = ArrayErstellen(a);
            Console.WriteLine("До");
            ArrayAnzeigen(b, a);
            b = Permutationen(b, a);
            Console.WriteLine("После");
            ArrayAnzeigen(b, a);
        }
        static int[] ArrayErstellen(int a)
        {
            int[] b = new int[a];
            var rand = new Random();
            int p = 100;
            for (int i = 0; i < a; i++)
            {
                b[i] = rand.Next(p);
            }
            return b;
        }
        static int[] Permutationen(int[] b, int a)
        {
            int p = (a / 2);
            for(int i=0; i<p;i++)
            {
                int x = 0;
                int y = a - i-1;
                x = b[i];
                b[i] = b[y];
                b[y] = x;
            }
            return b;
        }
        static void ArrayAnzeigen(int[]b,int a)
        {
            for(int i=0;i<a;i++)
            {
                Console.Write(b[i]+", ");
            }
            Console.WriteLine("");
        }
    }
}