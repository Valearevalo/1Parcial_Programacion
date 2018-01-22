using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avanzada.clases
{
    public class clsOpcion1
    {
        public void Tabla()
        {
            int a, b, i;
            string operacion;
            i = 1;

            Console.Write(" **--Escriba el Número a Multiplicar --**\n");
            operacion = Console.ReadLine();
            a = int.Parse(operacion);
            while (i <= 12)
            {
                b = i * a;
                Console.Write(a + "*" + i + "=" + b);
                operacion = Console.ReadLine();

                i = i + 1;
            }
            Console.Write("\n\t**-- Listo Operacion Terminada --**");
            Console.ReadKey();
        }
    }
}