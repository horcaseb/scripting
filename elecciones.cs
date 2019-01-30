using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese votos por el partido 1");
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos por el partido 2");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero de poblacion");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese porcentaje mayor de edad");
            int porcentaje = int.Parse(Console.ReadLine());
            int votantes = votos1 + votos2 + blancos + anulados;
            int mayores = poblacion *  (int)((double)(porcentaje) / 100);
            int abstencion = mayores - votantes;

            Console.WriteLine("poblacion mayor de edad:" + mayores);



            bool a = anulados < (0.3 * (votos1 + votos2));
            bool b = (votos1 + votos2) > blancos;
            bool c =  abstencion< votantes;

            if ((a || b) && (c))
            {

                Console.WriteLine("las elecciones son exitosas");
                if (votos1 > votos2)
                {
                    Console.WriteLine("gano partido 1");

                }
                else
                {
                    Console.WriteLine("gano partido 2");

                }

            }
            else
            {
                Console.WriteLine("hay que repetir las elecciones");
            }



        

            

        }
    }
}
