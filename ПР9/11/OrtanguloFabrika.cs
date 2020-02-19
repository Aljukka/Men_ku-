using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    class OrtanguloFabrika:FigurFabrika
    {
        public override IkolkulasArea Create(string imja, double[] parametry)
        {
            return new Ortangulo(parametry[1], parametry[2], imja);
        }
    }
}
