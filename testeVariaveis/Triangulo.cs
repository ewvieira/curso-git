using System;
using System.Collections.Generic;
using System.Text;

namespace testeVariaveis
{
    class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

        }

    }
}
