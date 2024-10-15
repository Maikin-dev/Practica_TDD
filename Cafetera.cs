using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    internal class Cafetera
    {

        private int cantidad_cafe;

        public int CantidadCafe { get => cantidad_cafe; set => cantidad_cafe = value; }

        public Cafetera(int cantidad_cafe)
        {
            CantidadCafe = cantidad_cafe;
        }

        public override string ToString()
        {
            return $"Esta es la cantidad de cafe que hay: {CantidadCafe}ml";
        }
    }
}
