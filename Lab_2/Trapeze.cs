using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Trapeze : Figure 
    {
        public double base1 { get; set; }
        public double base2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (base1 + base2)*Height/2;
        }
    }
}
