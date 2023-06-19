﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class Circle : IShape
    {
        public double Radius {get; set;}

        public Circle(double radius)
        {

            Radius = radius;

        }

        public double CalculateArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }
    }
}
