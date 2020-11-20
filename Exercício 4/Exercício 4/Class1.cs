﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_4
{
    class Triangulo
    {
        double @base;
        double altura;
        double area;

        public void SetBase(double p)
        {
            @base = p; 
        }

        public void SetAltura(double p)
        {
            altura = p;
        }

        public double GetBase()
        {
            return @base;
        }

        public double GetAltura()
        {
            return altura;
        }

        public double GetArea()
        {
            return area;
        }

        public double CalcularArea()
        {
            area = (@base * altura) / 2;
            return area;
        }
    }
}
