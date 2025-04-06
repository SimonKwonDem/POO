using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio2
{
    internal class Automovil: Vehículo
    {
        private float capTanque;
        private int cantPuertas;

        public float CapTanque 
        {
            get {return capTanque; }
            set { capTanque = value; }     
        }
        public int CantPuertas
        {
            get { return cantPuertas; }
            set { cantPuertas = value; }
        }
        
        public void CargarTanque(float capTanque)
        {
            Console.WriteLine($"Cargando gasolina... La capacidad del tanque es: {capTanque} lts.");
        }
        public override void EncenderVehículo()
        {
            Console.WriteLine("Encendiendo automóvil...");
        }
        public override void AcelerarVehículo()
        {
            Console.WriteLine("Acelerando automóvil...");
        }
        public override void FrenarVehículo()
        {
            Console.WriteLine("Frenando automóvil...");
        }
        public override void DetenerVehículo()
        {
            Console.WriteLine("Deteniendo automóvil...");
        }

    }
}
