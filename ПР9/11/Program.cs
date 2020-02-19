using System;
using System.Collections.Generic;
using System.IO;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo Triangulo = new Triangulo(12, 6, "треугольник");
            IkolkulasArea figur = new Ortangulo(12, 12, "pryam");
            Cirklo Cirklo = new Cirklo("круг", 12);
            Ortangulo Ortangulo = new Ortangulo(12, 2, "прямоугольник");
            Trapecio Trapecio = new Trapecio(24, 2, 3, "трапеция");
            Kvadrato Kvadrato = new Kvadrato(2, 2, "квадрат");
            Triangulo.KolkulasArea();
            Cirklo.KolkulasArea();
            Ortangulo.KolkulasArea();
            Trapecio.KolkulasArea();
            Kvadrato.KolkulasArea();
            List<IkolkulasArea> IkolkulasAreas = new List<IkolkulasArea>();
            IkolkulasAreas.Add(Triangulo);
            IkolkulasAreas.Add(Cirklo);
            IkolkulasAreas.Add(Ortangulo);
            IkolkulasAreas.Add(Trapecio);
            IkolkulasAreas.Add(Kvadrato);
            KolkulasKajPrezentas(IkolkulasAreas);
            Console.ReadLine();
        }
        static void KolkulasKajPrezentas(List<IkolkulasArea> ikolkulasAreas)
        {
            foreach (var figura in ikolkulasAreas)

                Console.WriteLine(figura.KolkulasArea());
        }
        static public void Initialize()
        {
            List<IkolkulasArea> list1 = new List<IkolkulasArea>();
            List<IkolkulasArea> list2 = new List<IkolkulasArea>();
            using (StreamReader f2 = new StreamReader("imput2.txt"))
            {
                string line;
                while ((line = f2.ReadLine()) != null)
                {
                    string[] result = line.Split(" ");
                    string imja = result[0];
                    double[] parametrs = new double[result.Length - 1];
                    for (int i = 1; i < result.Length; i++)
                    {
                        parametrs[i - 1] = Convert.ToDouble(result[i]);
                    }
                    IkolkulasArea current;
                    FigurFabrika CurrentFactory = null;
                    switch (imja)
                    {
                        case "Cirklo":
                            CurrentFactory = new CirkloFabrika();
                            break;
                        case "Pryamogolnik":
                            CurrentFactory = new OrtanguloFabrika();
                            break;
                        case "Triangulo":
                            CurrentFactory = new TrianguloFabrika();
                            break;
                        case "Kvadrato":
                            CurrentFactory = new KvadratooFabrika();
                            break;
                        case "Trapecio":
                            CurrentFactory = new TrapecioFabrika();
                            break;
                    }
                    current = CurrentFactory.Create(imja, parametrs);
                    list2.Add(current);
                }
            }
        }
    }
}