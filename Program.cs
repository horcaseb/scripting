using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el valor de Y");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de Z");
            double Z = double.Parse(Console.ReadLine());
            double T = Math.Sqrt((Y * Y) + (Z * Z));
            double C1 = Math.Asin(Z/T);
            double C = C1 * (180 / Math.PI);
            double A1 = Math.Asin(Y / T);
            double A = A1 * (180 / Math.PI);

            Console.WriteLine(" el valor de C : " + C);
            Console.WriteLine(" el valor de T : " + T);
            Console.WriteLine(" el valor de A : " + A);
        }
    }
}
