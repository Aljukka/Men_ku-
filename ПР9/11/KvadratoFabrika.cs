using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    class KvadratooFabrika:FigurFabrika
    {
        public override IkolkulasArea Create(string imja, double[] parametry)
        {
            return new Kvadrato(parametry[1], parametry[2], imja);
        }
    }
}
