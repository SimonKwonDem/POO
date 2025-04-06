using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio2
{
    internal class Motocicleta: Vehículo
    {
        private int cilindrada;
        private string tipoNeumatico;

        public int Cilindrada 
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        public string TipoNeumatico 
        {
            get { return tipoNeumatico; }
            set {  tipoNeumatico = value; }
        }
        public void InflandoNeumáticos()
        {
            Console.WriteLine("Inflando neumático..");
        }
        public override void EncenderVehículo()
        {
            Console.WriteLine("Encender motocicleta");
        }
        public override void AcelerarVehículo()
        {
            Console.WriteLine("Acelerar motocicleta");
        }
        public override void FrenarVehículo()
        {
            Console.WriteLine("Frenar motocicleta");
        }
        public override void DetenerVehículo()
        {
            Console.WriteLine("Detener motocicleta");
        }
    }
}
