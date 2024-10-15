namespace PRUEBA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info Informacion = new Info();
            RandomData randomData = new RandomData();
            Vasos vasos = new Vasos(randomData.randomVaso(), randomData.randomVaso(), randomData.randomVaso());
            Azucarera azucar = new Azucarera(randomData.randomAzucar());
            Cafetera Cafe = new Cafetera(randomData.randomCafe());


            Console.WriteLine("Este programa sirve para simular una cafetera");

            bool bucle = false;

            while (bucle != true)
            {
                Informacion.MostrarInsumos(vasos, azucar,Cafe);

                Informacion.ElegirVaso();

                int opcion = Convert.ToInt32(Console.ReadLine());

                vasos.EleccionVaso(opcion);

                Cafe.ServirCafe(vasos,opcion);

                Informacion.CantidadAzucar();

                int elegir = Convert.ToInt32(Console.ReadLine());

                azucar.ServirAzucar(elegir);

                bucle = Informacion.OtroCafe();
            }
        }
    }
}