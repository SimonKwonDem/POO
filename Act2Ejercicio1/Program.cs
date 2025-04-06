using Act2Ejercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        Autobús autobús1 = new Autobús("Ford", "Rojo", "fiesta", 10000);
        autobús1.CantPuertas = 3;
        autobús1.CantAsientos = 15;
        autobús1.CargaPasajeros();
        autobús1.DescargaPasajeros();

        Console.ReadKey();
        
    }
}