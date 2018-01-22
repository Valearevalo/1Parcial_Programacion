using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avanzada
{
    class Program
    {
        static void Main(string[] args)
        {
            int intento =1;
            string cingreso ="1234";
            string clave;


            Console.WriteLine("\t----****Universidad Politecnica de Nicaragua UPOLI----***");
            Console.WriteLine("\t***--  Proyecto Programacion Avanzada I Parcial  --***\n ");
            Console.WriteLine("\t\t**** Elaborado por: Valeria Arevalo Sotelo ****\n");
            Console.WriteLine("\t*******-----------------------------------------*********\n");



            do
            {
                Console.WriteLine("Digite la Clave de Inicio (Intento n°. " + intento + "):\n");
                clave = Console.ReadLine();

                if( clave == cingreso)
                {
                    clases.clsMenu menu = new clases.clsMenu();
                    menu.ListaOpcion();
                                        
                    break;
                }
                else
                {
                    intento++;
                    Console.WriteLine("\n---Clave Incorrecta---\n");
                }


            } while (intento <= 3);

            Console.ReadKey();


        }
       }
}
