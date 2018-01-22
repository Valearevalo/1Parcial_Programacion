using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avanzada.clases
{
   public class clsOpcion3
    {
       public int resultado { get; set; }
       public int a, b;
       
       public virtual void Operaciones()
       {
           Console.WriteLine("Digite el primer numero:\n");
           a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite el segundo numero:\n");
           b = Convert.ToInt32(Console.ReadLine());
           resultado = a + b;
           Console.WriteLine("El resultado es{0}:", resultado);
           Console.Read();
        }
    }

    class suma: clsOpcion3
    {
       
        public override void Operaciones()
        {
            //base.resultado = a+b ;
           //Console.WriteLine("El resultado es{0}:", resultado);
           // Console.Read();
        }
    }

}
