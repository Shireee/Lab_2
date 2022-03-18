using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Circle: Figure
    {
        public double r { get; set; }
        public override double GetArea()
        {
            return r * r * Math.PI;
        }
    }
}
