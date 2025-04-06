using Act2.Ejercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal a1 = new Animal();
        a1.Especie = "mamífero";
        a1.Edad = 7;
        a1.Género = "macho";
        a1.Tamaño = "grande";
        a1.CoberturaCorporal = "Pelos";
        a1.Comer();
        a1.Reproducir();
        a1.SonidoAnimal();

        Perro p1 = new Perro();
        p1.Especie = "Mamífero";
        p1.Edad = 8;
        p1.Género = "Macho";
        p1.Tamaño = "Mediano";
        p1.CoberturaCorporal = "Pelos";
        p1.Raza = "Border Collie";
        p1.PatrónPelaje = "Marcas distintivas en cuello, pecho";
        p1.Temparamento = "Sensible, ágil y afectuoso";
        p1.PiruetaAprendida = "Rodar en el piso";
        p1.Comer();
        p1.Reproducir();
        p1.SonidoAnimal();
        p1.RealizarPirueta();
        p1.OlfatearRastro();
        
        //sólo instancie el objeto de animal y perro 
    }
}

