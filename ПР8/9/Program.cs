using System;
using System.Collections.Generic;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<pokupatel, List<tovar>> journal = Initial();
            Menju(ref journal);
        }
        static void Menju(ref Dictionary<pokupatel, List<tovar>> journal)
        {
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine("");
            Console.WriteLine("1. Список покупателей");
            Console.WriteLine("2. Добавить покупателя");
            Console.WriteLine("3. Удалить покупателя");
            Console.WriteLine("4. Список товаров");
            Console.WriteLine("5. Список покупателей с товарами");
            Console.WriteLine("6. Добавить товар покупателю");
            Console.WriteLine("7. Удалить товар у покупателя");
            Console.WriteLine("0. Выход");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (x)
            {
                case 1:
                    SpisokPokup(journal);
                    break;
                case 2:
                    DobPok(ref journal);
                    break;
                case 3:
                    UdalPok(ref journal);
                    break;
                case 4:
                    SpisokTov(tov);
                    break;
                case 5:
                    Spisok(journal);
                    break;
                case 6:
                    DobTov(ref journal);
                    break;
                case 7:
                    UdTov(ref journal);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Повторите ввод");
                    break;
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу");
            Console.ReadLine();
            Console.Clear();
            Menju(ref journal);
        }
        struct pokupatel
        {
            string fam;
            string tel;
            public pokupatel(string fam, string tel)
            {
                this.fam = fam;
                this.tel = tel;
            }
            public void show(string beggining = "")
            {
                Console.WriteLine(beggining + this.fam + " тел. " + this.tel);
            }
        }
        struct tovar
        {
            string naz;
            int cen;
            public tovar(string naz, int cen)
            {
                this.naz = naz;
                this.cen = cen;
            }
            public void show(string beggining = "")
            {
                Console.WriteLine(beggining + this.naz + " - " + this.cen);
            }
        }
        static List<tovar> tov;
        static Dictionary<pokupatel, List<tovar>> Initial()
        {
            tovar gv = new tovar("Гвозди", 100);
            tovar ds = new tovar("Доски", 50);
            tovar kp = new tovar("Кирпичи", 500);
            tov = new List<tovar>();
            tov.Add(gv);
            tov.Add(ds);
            tov.Add(kp);
            pokupatel a = new pokupatel("Иванов", "8 800 555 35 35");
            pokupatel b = new pokupatel("Петров", "8 956 848 76 75");
            pokupatel c = new pokupatel("Сидоровов", "9 850 685 55 99");
            Dictionary<pokupatel, List<tovar>> pok = new Dictionary<pokupatel, List<tovar>>();
            pok.Add(a, new List<tovar>());
            pok.Add(b, new List<tovar>() { gv, ds });
            pok.Add(c, new List<tovar>() { kp });
            return pok;
        }
        static void SpisokPokup(Dictionary<pokupatel, List<tovar>> journal)
        {
            int i = 0;
            foreach (var pokupatel in journal.Keys)
                pokupatel.show((++i) + ". ");
        }
        static void DobPok(ref Dictionary<pokupatel, List<tovar>> journal)
        {
            string fam = Console.ReadLine();
            string tel = Console.ReadLine();
            journal.Add(new pokupatel(fam, tel), new List<tovar>());
        }
        static void UdalPok(ref Dictionary<pokupatel, List<tovar>> journal)
        {
            SpisokPokup(journal);
            int x = Convert.ToInt32(Console.ReadLine());
            pokupatel udal = new pokupatel();
            int y = 1;
            foreach (var pokupatel in journal.Keys)
            {
                if (y == x)
                {
                    udal = pokupatel;
                    break;
                }
                y++;
            }
            journal.Remove(udal);
        }
        static void SpisokTov(List<tovar> tov)
        {
            int i = 0;
            foreach (var tovar in tov)
                tovar.show((++i) + ". ");
        }
        static void Spisok(Dictionary<pokupatel, List<tovar>> journal)
        {
            int i = 0;
            foreach (var peir in journal)
            {
                peir.Key.show((++i) + ". ");
                foreach (var tovar in peir.Value)
                {
                    tovar.show(" ");
                }
            }
        }
        static void DobTov(ref Dictionary<pokupatel, List<tovar>> journal)
        {
            SpisokPokup(journal);
            int x = Convert.ToInt32(Console.ReadLine());
            pokupatel z = new pokupatel();
            int y = 1;
            foreach (var pokupatel in journal.Keys)
            {
                if (y == x)
                {
                    z = pokupatel;
                    break;
                }
                y++;
            }
            SpisokTov(tov);
            int n = Convert.ToInt32(Console.ReadLine());
            int v = 1;
            foreach (var tovar in tov)
            {
                if (v == n)
                {
                    journal[z].Add(tovar);
                }
                v++;
            }
        }
        static void UdTov(ref Dictionary<pokupatel, List<tovar>> journal)
        {
            Spisok(journal);
            int x = Convert.ToInt32(Console.ReadLine());
            pokupatel z = new pokupatel();
            int y = 1;
            foreach (var pokupatel in journal.Keys)
            {
                if (y == x)
                {
                    z = pokupatel;
                    break;
                }
                y++;
            }
            int n = Convert.ToInt32(Console.ReadLine());
            int v = 1;
            foreach (var tovar in tov)
            {
                if (v == n)
                {
                    journal[z].Remove(tovar);
                }
                v++;
            }

        }
    }
}
