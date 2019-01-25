using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas_triangulos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de B");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de Y");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de Z");
            double Z = double.Parse(Console.ReadLine());

            double C = Math.Atan(Z / Y);
            double C1 = C * 180 / Math.PI;
            double E = 180 - C1;
            double D = 180 - E - B;
            double T = Math.Sqrt((Y * Y) + (Z * Z));
            double B1 = B * Math.PI / 180;
            double D1 = D * Math.PI / 180;
            double X = (Math.Sin(B1)*T)/Math.Sin(D1);

            Console.WriteLine("el valor de X es :"+X);
        }
    }
}
