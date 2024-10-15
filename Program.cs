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
                Informacion.ElegirVaso();
                int opcion = Convert.ToInt32(Console.ReadLine());   

                switch (opcion)
                {
                       
                    case 1:
                        Console.WriteLine("paso 1");
                        break;

                    case 2:
                        Console.WriteLine("paso 2");
                        break;

                    case 3:
                        Console.WriteLine("paso 3");
                        break;

                    case 4:
                        Console.WriteLine("paso 4");
                        break;

                }



            }
        }
    }
}