internal class Program
{
    private static void Main(string[] args)
    {
        Libro l1 = new Libro();
        l1.Título = "El señor de los Anillos";
        l1.Autor = "John Ronald Reuel Tolkien";
        l1.AñoPublicación = 1954;
        l1.Género = "Fantasía épica";
        l1.AbrirLibro();
        l1.LeerLibro();
        l1.CerrarLibro();

        Console.ReadKey();
    }

    class Libro
    {
        private string título;
        private string autor;
        private int añoPublicación;
        private string género;

        public string Título
        {
            get { return título; }
            set { título = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int AñoPublicación
        {
            get { return añoPublicación; }
            set { añoPublicación = value; }
        }
        public string Género
        {
            get { return género; }
            set { género = value;}
        }

        public void AbrirLibro()
        {
            Console.WriteLine($"Abriendo el libro {título}");
        }
        public void CerrarLibro()
        {
            Console.WriteLine($"Cerrando el libro {título}");
        }
        public void LeerLibro()
        {
            Console.WriteLine($"Leyendo {título}");
        }
    }
}