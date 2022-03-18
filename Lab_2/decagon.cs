using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Decagon : Figure
    {
        public double a { get; set; }

        public override double GetArea()
        {
            return 2.5 * a * a * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
