using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triugulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи страната А: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи височината H: ");
            double h = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, h);
            Console.WriteLine($"Триъгълник със страна {triangle.PrintA()}cm и височина към нея {triangle.PrintH()}cm.");

            triangle.Print();
        }
    }
}
