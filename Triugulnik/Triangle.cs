using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triugulnik
{
    internal class Triangle
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double h;

        public double H
        {
            get { return h; }
            set { h = value; }
        }

        public Triangle(double a, double h)
        {
            this.A = a;
            this.H = h;
        }

        public double Area()
        {
            double area;
            area = a * h / 2;
            return area;
        }

        public void Print()
        {
            Console.WriteLine($"Лицето = {a} * {h} / 2 = {Area()} cm2!");
        }

        public double PrintA()
        {
            return a;
        }

        public double PrintH()
        {
            return h;
        }
    }
}
