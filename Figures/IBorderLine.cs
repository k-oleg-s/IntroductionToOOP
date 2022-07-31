using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal interface IBorderLine
    {
        public int LineWidth { get; set; }
        string LineStyle { get; set; }
    }
}
