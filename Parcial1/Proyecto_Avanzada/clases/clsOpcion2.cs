using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avanzada.clases
{
 public  class clsOpcion2
    {
      public void listado()
     {
         List<string> lista = new List<string>();
         Console.WriteLine("******-- Libros Escolares --*****\n");
         lista.Add(" *- Matematica Primaria   \n");
         lista.Add(" *- Matematica Secundaria  \n");
         lista.Add(" *- Algebra Baldor  \n");
         lista.Add(" *- Matematica Basica   \n");
         lista.Add(" *- Aritmetica  ");
         Console.WriteLine(lista[0] + lista[1] + lista[2] + lista[3] + lista[4] );
         Console.ReadKey();
          
     }

    }
}
