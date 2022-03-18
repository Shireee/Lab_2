﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Pentagon : Figure
    {
        public double h { get; set; }
        public double b { get; set; }

        public override double GetArea()
        {
            return h * b * 0.5 * 5;
        }
    }
}