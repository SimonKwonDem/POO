using Act2.Ejercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehículo v1 = new Vehículo();
        v1.Modelo = "sedan";
        v1.Marca = "honda";
        v1.Color = "Rojo";
        v1.TipoMotor = "v6";
        v1.Año = 2010;
        v1.NumSerie = "sd23d";
        v1.EncenderVehículo();
        v1.DetenerVehículo();
        v1.AcelerarVehículo();
        v1.FrenarVehículo();

        Automovil a1 = new Automovil();
        a1.Marca = "Chevrolet";
        a1.Modelo = "s10";
        a1.Color = "Negro";
        a1.TipoMotor = "Gasolero";
        a1.Año = 2010;
        a1.NumSerie = "22dsdas3";
        a1.CapTanque = 20;
        a1.CantPuertas = 4;
        a1.EncenderVehículo();
        a1.DetenerVehículo();
        a1.AcelerarVehículo();
        a1.FrenarVehículo();

        //Aquí debería, si quisiera, instanciar los objetos de la la clase motocicleta y camion.
        //Se podrían instanciar los objetos que quisiera.
    }
}