internal class Program
{
    private static void Main(string[] args)
    {
        Auto a1 = new Auto();
        a1.color = "Rojo";
        a1.marca = "Audi";
        a1.cantPuertas = 2;
        a1.capacidadTanque = 40;
        a1.Encender();
        a1.LlenarTanque();
        Console.WriteLine();

        Persona p1 = new Persona();
        p1.nombre = "José";
        p1.apellido = "Pérez";
        p1.edad = 23;
        p1.ocupación = "programador";
        p1.Caminar();
        p1.Trabajar();
        Console.ReadKey();
    }

    public class Auto
    {
        public string color;
        public string marca;
        public int cantPuertas;
        public double capacidadTanque;

        public void LlenarTanque()
        {
            Console.WriteLine($"Cargando nafta al tanque... capacidad máxima: {capacidadTanque} litros");
        }
        public void Encender()
        {
            Console.WriteLine("Encendiendo automóvil");
        }
    }

    public class Persona
    {
        public string nombre;
        public string apellido;
        public string ocupación;
        public int edad;

        public void Trabajar()
        {
            Console.WriteLine($"El {ocupación}, {nombre} {apellido} se encuentra trabajando");
        }
        public void Caminar()
        {
            Console.WriteLine($"{nombre} {apellido} camina hacia su trabajo");
        }
    }
}    
