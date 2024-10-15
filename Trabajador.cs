using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    public class Trabajador
    {

        public static void rellenarCafetera(Cafetera cafe, int cantidad)
        {
            cafe.CantidadCafe += cantidad;
            Console.WriteLine("La cafetera se ha rellenado a 2L (2000ml)");
        }

        public static void rellenarVasos(Vasos vasos, int cantidad, int tipo)
        {
            if(tipo == 1)
            {
                vasos.VasosSmall += cantidad;
                Console.WriteLine("Se rellenaron los portavasos a 10");
            }
            else if(tipo == 2)
            {
                vasos.VasosMedium += cantidad;
                Console.WriteLine("Se rellenaron los portavasos a 10");
            }
            else if (tipo == 3)
            {
                vasos.VasosLarge += cantidad;
                Console.WriteLine("Se rellenaron los portavasos a 10");
            }
        }

        public static void rellenarAzucarera()
        {
            Console.WriteLine("Se relleno la azucarera ya tiene 20 cucharadas mas de azucar");

        }
    }
}
