using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avanzada.clases
{
   public class clsMenu
    {
       public void ListaOpcion()
       {
           string opcion = "0";
           do
           {
               Console.Clear();
               Console.WriteLine(" \t\t*** MENU MATEMÁTICO *** \n\n\t Digite la Opcion Deseada:\n " + "\n\t1.-- Tabla de Multiplicar" + "\n\t2.-- Biblioteca Matematica" + "\n\t3.-- Conexion" + "\n\t4.-- Salir\n");
               opcion = Console.ReadLine();

               switch(opcion)
               {
                   case "1":
                       clases.clsOpcion1 opcion1 = new clases.clsOpcion1();
                       opcion1.Tabla();                       
                       break;

                   case "2":
                       clases.clsOpcion2 opcion2 = new clases.clsOpcion2();
                       opcion2.listado();
                       break;

                   case "3":
                        clases.clsOpcion3 opcion3 = new clases.clsOpcion3();
                       opcion3.Operaciones();
                       break;

                   case "4":
                       clases.clsOpcion4 opcion4 = new clases.clsOpcion4();
                       opcion4.presentar();
                       break;
                   default:
                       Console.WriteLine("Opcion no valida");
                       Console.ReadKey();
                       break;
               }
              
           } while (opcion != "0");
       }

      

    }
}
