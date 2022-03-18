﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public  class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        private double p { get; set; }
      
        public override double GetArea()
        {
            p = (a + b + c)/2;
            return  Math.Sqrt((p*(p - a)*(p - b)*(p - c)));
        }

    }
}
