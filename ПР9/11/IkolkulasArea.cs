using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    public interface IkolkulasArea
    {
        public double KolkulasArea();
        string Imja { get; set; }
        public virtual void Pokazhi()
        {
            Console.WriteLine(this.Imja + "," + "Площадь" + "=" + this.KolkulasArea());
        }
    }
}
