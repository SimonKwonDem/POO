using Act2.Ejercicio5;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca b1 = new Biblioteca("Santa Biblio", "Rivadavia 6655", "10:00 AM", "20:15 PM");
        Libro libro1 = new Libro("Blancanieves", "Cortazar", 1990, "romance", false);
        Libro libro2 = new Libro("Los 3 chanchitos", "Borges", 1980, "fantasia", false);

        b1.AgregarLibro(libro1);
        b1.AgregarLibro(libro2);
        b1.BuscarLibro("cars");
        b1.BuscarLibro("Blancanieves");
        b1.PrestarLibro("t-rex");
        b1.PrestarLibro("Los 3 chanchitos");
        b1.PrestarLibro("Los 3 chanchitos");
        b1.MostrarLibros();
    }
}