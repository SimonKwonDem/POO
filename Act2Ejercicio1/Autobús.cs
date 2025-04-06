using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Ejercicio1
{
    internal class Autobús:Vehículo
    {
        private int cantPuertas;
        private int cantAsientos;
        private int kilometraje;

        public int CantPuertas 
        {
            get { return cantPuertas; }
            set { cantPuertas = value; } 
        }
        public int CantAsientos
        {
            get { return cantAsientos; }
            set { cantAsientos = value; }
        }
        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        public void CargaPasajeros()
        {
            Console.WriteLine("Pasajeros subiendo..");
        }
        public void DescargaPasajeros()
        {
            Console.WriteLine("Pasajeros bajando..");
        }

        public Autobús(string marca, string color, string modelo, int kilometraje) : base(marca, color, modelo)
        {
           this.kilometraje = kilometraje;
        }
    }
}
