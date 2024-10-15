using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    public class Vasos
    {
        private int vasos_small;
        private int vasos_medium;
        private int vasos_large;

        public int capacidad_small = 90;
        public int capacidad_medium = 150;
        public int capacidad_large = 200;


        public int VasosSmall { get => vasos_small; set => vasos_small = value; }
        public int VasosMedium { get => vasos_medium; set => vasos_medium = value; }
        public int VasosLarge { get => vasos_large; set => vasos_large = value; }

        public Vasos(int vasosSmall, int vasosMedium, int vasosLarge)
        {
            VasosSmall = vasosSmall;
            VasosMedium = vasosMedium;
            VasosLarge = vasosLarge;
        }

        public void EleccionVaso(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    VerificacionVasos(opcion);
                    VasosSmall -= 1;
                    Console.WriteLine("Haz tomado un vaso small");
                    break;

                case 2:
                    VerificacionVasos(opcion);
                    VasosMedium -= 1;
                    Console.WriteLine("Haz tomado un vaso medium");
                    break;

                case 3:
                    VerificacionVasos(opcion);
                    VasosLarge -= 1;
                    Console.WriteLine("Haz tomado un vaso large");
                    break;

                case 4:
                    Console.WriteLine("Vuelva Pronto");
                    Environment.Exit(0);
                    break;
            }
        }

        public void VerificacionVasos(int TipoVaso)
        {
            switch(TipoVaso)
            {
                case 1:
                    if (VasosSmall < 1)
                    {
                        Console.WriteLine("No hay vasos deseas llamar a un reponedor o prefieres irte?");
                        Console.WriteLine("Presione:\n1.Llamar Reponedor \n2.Irme \n");
                        int opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine("Llamando a reponedor:\n.\n..\n...\n....\n.....\n");
                            Trabajador.rellenarVasos(this, 10, TipoVaso);
                        }else if (opcion == 2)
                        {
                            Console.WriteLine("Vuelva Pronto");
                            Environment.Exit(0);
                        }
                    }
                    break;

                case 2:
                    if (VasosMedium < 1)
                    {
                        Console.WriteLine("No hay vasos deseas llamar a un reponedor o prefieres irte?");
                        Console.WriteLine("Presione:\n1.Llamar Reponedor \n2.Irme \n");
                        int opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine("Llamando a reponedor:\n.\n..\n...\n....\n.....\n");
                            Trabajador.rellenarVasos(this, 10, TipoVaso);
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Vuelva Pronto");
                            Environment.Exit(0);
                        }
                    }
                    break;

                case 3:
                    if (VasosLarge < 1)
                    {
                        Console.WriteLine("No hay vasos deseas llamar a un reponedor o prefieres irte?");
                        Console.WriteLine("Presione:\n1.Llamar Reponedor \n2.Irme \n");
                        int opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine("Llamando a reponedor:\n.\n..\n...\n....\n.....\n");
                            Trabajador.rellenarVasos(this, 10, TipoVaso);
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Vuelva Pronto");
                            Environment.Exit(0);
                        }
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"Esta es la cantidad de vasos que hay de vasos:\n vasos pequeños:{VasosSmall} \n vasos medianos: {VasosMedium} \n vasos grandes:{VasosLarge}";
        }
      

    }
}
