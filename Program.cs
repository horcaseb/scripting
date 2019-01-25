using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el valor de T");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de A");
            double A1 = double.Parse(Console.ReadLine());

            double A = (Math.PI / 180) * A1;
            double C1 = 90 - A1;
            double C = (Math.PI / 180) * C1;
            double Z = (Math.Sin(C) * T);
            double Y = (Math.Sin(A) * T);

            Console.WriteLine(" el valor de C : " + C1);
            Console.WriteLine(" el valor de Z : " + Z);
            Console.WriteLine(" el valor de Y : " + Y);

        }
    }
}
