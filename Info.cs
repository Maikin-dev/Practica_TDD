using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    public class Info
    {

        public void ElegirVaso()
        {
            Console.WriteLine(" \n!!! Vamos a tomar un café !!!\n");
            Console.WriteLine("Elige un vaso: ");
            Console.WriteLine("1.Vaso de 90ml");
            Console.WriteLine("2.Vaso de 150ml");
            Console.WriteLine("3.Vaso de 200ml");
            Console.WriteLine("4.Me arrepiento no quiero beber café\n");
        }


        public void CantidadAzucar()
        {
            Console.WriteLine("Cuantas Cucharadas de azucar deseas agregar?");
            Console.WriteLine("1.Una cucharada");
            Console.WriteLine("2.Dos cucharada");
            Console.WriteLine("3.Tres cucharada");
            Console.WriteLine("4.No quiero azucar");
        }
        

        public void MostrarInsumos(Vasos vasos, Azucarera azucarera, Cafetera cafetera)
        {
            Console.WriteLine("Quieres ver los insumos de la maquina?\nPresione:\n1.Si\n2.No\n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Estos son los insumo: ");
                Console.WriteLine(vasos);
                Console.WriteLine(azucarera);
                Console.WriteLine(cafetera);
            }
        }

        public bool OtroCafe()
        {
            Console.WriteLine("Quiere otro Cafe?\nPresione:\n1.Si\n2.No");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1 )
            {
                Console.WriteLine("Hasta Pronto.");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
