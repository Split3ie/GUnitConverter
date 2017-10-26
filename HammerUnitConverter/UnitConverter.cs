using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerUnitsConverter
{
    public class UnitConverter
    {
        private double _mm;
        private double _unit;
        private double _inch;
        private double _foot;
        private double _cm;
        public double Unit => _unit * 10;
        public double Inch => _inch;
        public double Foot => _inch / 12;
        public double Cm => _cm;
        public double M => _cm / 100;
        public double MM => _cm * 10;

        public void MakeConvertToUnit(double cm)
        {
            _cm = cm;
            _unit = (double)_cm / 19.05;

            _inch = (double)(_cm * 0.39370079);
            _foot = _inch / (double)12;
        }
        public void MakeConvertToCm(double unit)
        {
            _unit = unit/10;
            _cm = _unit * 19.05;
            _inch = _unit * 0.75;

        }
    }
}
