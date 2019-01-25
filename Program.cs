using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de C");
            double C1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de Z");
            double Z = double.Parse(Console.ReadLine());

            double A1 = 90 - C1;
            double A = A1 * (Math.PI / 180);
            double C = C1 * (Math.PI / 180);
            double T = (Z / Math.Sin(C));
            double Y = Math.Sin(A) * (T);

            Console.WriteLine(" A vale: " + A1);
            Console.WriteLine(" T vale: " + T);
            Console.WriteLine(" Y vale: " + Y);


        }
    }
}
