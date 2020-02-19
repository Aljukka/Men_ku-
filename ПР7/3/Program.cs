using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 5;
            int value = 100;
            int[,] a = CreateArray(n, m, value);
            int[,] b = FyrFyr(a, n, m);
            ShowArray(b, n, m);
            Console.Read();
        }
        static void ShowArray(int[,] b, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
        static int[,] CreateArray(int n, int m, int value)
        {
            int[,] a = new int[n, m];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(-value, value);
                }
            }
            return a;
        }
        static int[,] FyrFyr(int[,] a, int n, int m)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for(int k = 0; k < n - 1; k++)
                {
                    for(int i = 0; i < n - 1; i++)
                    {
                        if(a[i,j]<a[i+1,j])
                        {
                            int bar = a[i, j];
                            a[i, j] = a[i + 1, j];
                            a[i + 1, j] = bar;
                        }
                    }
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int k = 0; k < m - 1; k++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (a[i, j] < a[i, j + 1])
                        {
                            int bar = a[i, j];
                            a[i, j] = a[i, j+1];
                            a[i, j +1] = bar;
                        }
                    }
                }
            }
            return a;
        }
    }
}
