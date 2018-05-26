using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerUnitsConverter.Logic
{
    public class ConvertModel
    {
        public float Units { get; set; }
        public float Cm { get; set; }
        public float Inches { get; set; }
        public float Feet { get; set; }
        public float M { get; set; }
        public SourceScale Source { get; set; }
    }
}
