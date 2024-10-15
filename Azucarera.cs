using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    internal class Azucarera
    {
        private int cantidad_azucar;

        public int CantidadAzucar { get => cantidad_azucar; set => cantidad_azucar = value; }

        public Azucarera(int cantidad_azucar)
        {
            CantidadAzucar = cantidad_azucar;
        }


        public override string ToString()
        {
            return $"Esta es la cantidad de azucar que hay: {CantidadAzucar} cucharadas";
        }

    }
}
