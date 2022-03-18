using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rhomb : Figure
    {
        public double a { get; set; }
        public double b { get; set; }

        public override double GetArea()
        {
            return 0.5 * a * b;
        }
    }
}
