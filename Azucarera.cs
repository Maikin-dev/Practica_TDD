using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    public class Azucarera
    {
        Info informacion = new Info();
        private int cantidad_azucar;
        private const int azucar_maxima = 20;

        public int CantidadAzucar { get => cantidad_azucar; set => cantidad_azucar = value; }

        public Azucarera(int cantidad_azucar)
        {
            CantidadAzucar = cantidad_azucar;
        }

        public void ServirAzucar(int elegir)
        {
            if (!Cucharadas(elegir))
            {
                return;  
            }

            bool bucle = true;
            while (bucle)
            {
                switch (elegir)
                {
                    case 1:
                        cantidad_azucar -= 1;
                        Console.WriteLine("Se ha echado una cucharada de azúcar");
                        bucle = false;
                        break;

                    case 2:
                        cantidad_azucar -= 2;
                        Console.WriteLine("Se han echado dos cucharadas de azúcar");
                        bucle = false;
                        break;

                    case 3:
                        cantidad_azucar -= 3;
                        Console.WriteLine("Se han echado tres cucharadas de azúcar");
                        bucle = false;
                        break;

                    case 4:
                        Console.WriteLine("No se ha echado ninguna cucharada de azúcar\n");
                        bucle = false;
                        break;
                }
            }
        }


        public bool Cucharadas(int elegir)
        {
            if (elegir == 4)
            {
                Console.WriteLine("");
                return true;
            }
            else if (elegir == 3 && cantidad_azucar >= elegir)
            {
                Console.WriteLine("Espere un momento...\n");
                return true;
            }
            else if (elegir == 2 && cantidad_azucar >= elegir)
            {
                Console.WriteLine("Espere un momento...\n");
                return true;
            }
            else if (elegir == 1 && cantidad_azucar >= elegir)
            {
                Console.WriteLine("Espere un momento...\n");
                return true;
            }
            else
            {
                Console.WriteLine("No hay azucar, ¿deseas llamar a un reponedor o prefieres irte?");
                Console.WriteLine("Presione:\n1. Llamar Reponedor \n2. Echar cantidad de azúcar disponible \n");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == 1)
                {
                    Console.WriteLine("Llamando a reponedor:\n.\n..\n...\n....\n.....\n");
                    Trabajador.rellenarAzucarera(this, azucar_maxima - cantidad_azucar);
                }
                else if (eleccion == 2)
                {
                    if (cantidad_azucar > 0)
                    {
                        Console.WriteLine($"Se han echado {cantidad_azucar} cucharadas de azúcar a su café");
                        cantidad_azucar = 0; 
                        Console.WriteLine("Vuelva pronto\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay azúcar.\n");
                    }
                }
                return false;
            }
        }


        public override string ToString()
        {
            return $"Esta es la cantidad de azucar que hay: \n {CantidadAzucar} cucharadas de azucar";
        }

    }
}
