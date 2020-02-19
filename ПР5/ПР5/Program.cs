using System;

namespace ПР5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите к");
            int k = Convert.ToInt32(Console.ReadLine());
            int aaa = Fibanachi(k);
            int z = Ziffer(aaa, k);
            Console.WriteLine("Вот вам ваша цифра. Зачем она вообще вам понадобилась?");
            Console.WriteLine(z);
        }
        static int Fibanachi(int k)
        {
            string f = "11";
            int r = 1;
            int a = 1;
            int b = 1;
            int c;
            int aaa;
            while (r < k - 1)
            {
                c = a + b;
                f = f + c;
                a = b;
                b = c;
                r++;
            }
            aaa = Convert.ToInt32(f);
            return aaa;
        }
        static int Ziffer(int aaa, int k)
        {
            int z = 0;
            int q = 0;
            int a = aaa;
            while (a>0)
            {
                q++;
                a = a / 10;
            }
            q = q - k+1;
            while (q > 0)
            {
                z = aaa % 10;
                aaa = aaa / 10;
                q--;
            }
            return z;
        }
    }
}