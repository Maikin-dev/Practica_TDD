using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    public class Cafetera
    {

        private int cantidad_cafe;
        private int cantidad_maxima = 2000;


        public int CantidadCafe { get => cantidad_cafe; set => cantidad_cafe = value; }

        public Cafetera(int cantidad_cafe)
        {
            CantidadCafe = cantidad_cafe;
        }

        public void ServirCafe(Vasos vaso, int opcion)
        {
            VerificarCafe(vaso, opcion);
                if (opcion == 1)
                {
                    cantidad_cafe -= 80;
                Console.WriteLine("Su vaso se ha llenado, quiere añadir azucar");
                }
                else if (opcion == 2)
                {
                    cantidad_cafe -= 140;
                    Console.WriteLine("Su vaso se ha llenado, quiere añadir azucar");
                }
                else if (opcion == 3)
                {          
                    cantidad_cafe -= 190;
                    Console.WriteLine("Su vaso se ha llenado, quiere añadir azucar");
                }
  
        }

        public void VerificarCafe(Vasos vaso, int opcion)
        {
            if (opcion == 3 && cantidad_cafe > vaso.capacidad_large - 11)
            {
                Console.WriteLine("Espere un momento...");
            }
            else if (opcion == 2 && cantidad_cafe > vaso.capacidad_medium - 11)
            {
                Console.WriteLine("Espere un momento...");
            } 
            else if(opcion == 1 && cantidad_cafe > vaso.capacidad_small - 11)
            {
                Console.WriteLine("Espere un momento...");
            }
            else
            {
                Console.WriteLine("No hay cafe deseas llamar a un reponedor o prefieres irte?");
                Console.WriteLine("Presione:\n1.Llamar Reponedor \n2.Irme \n");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 1)
                {
                    Console.WriteLine("Llamando a reponedor:\n.\n..\n...\n....\n.....\n");
                    Trabajador.rellenarCafetera(this, cantidad_maxima - cantidad_cafe);
                }
                else if (eleccion == 2)
                {
                    Console.WriteLine("Vuelva Pronto");
                    Environment.Exit(0);
                }
            }

        }

        public override string ToString()
        {
            return $"Esta es la cantidad de cafe que hay: {CantidadCafe}ml";
        }
    }
}
