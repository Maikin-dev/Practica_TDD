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
            Console.WriteLine(" !!! Vamos a tomar un café !!!");
            Console.WriteLine("Elige un vaso: ");
            Console.WriteLine("1.Vaso de 90ml");
            Console.WriteLine("2.Vaso de 150ml");
            Console.WriteLine("3.Vaso de 20ml");
            Console.WriteLine("4.Me arrepiento no quiero beber café");
        }


        public void CantidadAzucar()
        {
            Console.WriteLine("Cuantas Cucharadas de azucar deseas agregar?");
            Console.WriteLine("1.Una cucharada");
            Console.WriteLine("2.Dos cucharada");
            Console.WriteLine("3.Tres cucharada");
            Console.WriteLine("4.Otra cantidad de cucharadas");
            Console.WriteLine("5.No quiero azucar");
        }
        
    }
}
