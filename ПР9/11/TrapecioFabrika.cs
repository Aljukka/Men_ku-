using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    class TrapecioFabrika:FigurFabrika
    {
        public override IkolkulasArea Create(string imja, double[] parametry)
        {
            return new Trapecio(parametry[1], parametry[2], parametry[3], imja);
        }
    }
}
