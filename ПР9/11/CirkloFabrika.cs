using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    class CirkloFabrika:FigurFabrika
    {
        public override IkolkulasArea Create(string imja, double[]parametry)
        {
            return new Cirklo(imja, parametry[0]);
        }
    }
}
