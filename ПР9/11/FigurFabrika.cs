using System;
using System.Collections.Generic;
using System.Text;

namespace _11
{
    abstract class FigurFabrika
    {
        abstract public IkolkulasArea Create(string imja, double[] parametry);
    }
}
