using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio2
{
    internal class Camion
    {
        private string tipoCarga;
        private float capCarga;
        private float capRemolque;

        public string TipoCarga
        {
            get { return tipoCarga; }
            set { tipoCarga = value; }
        }
        public float CapCarga
        {
            get { return capCarga; }
            set { capCarga = value; }
        }
        public float CapRemolque
        {
            get { return capRemolque; }
            set { capRemolque = value; }
        }
        public void RealizandoCarga(string tipoCarga, float capCarga)
        {
            Console.WriteLine($"Cargando camion con {tipoCarga}, el límite es: {capCarga} ");
        }
        public void RemolcandoCarga(string tipoCarga)
        {
            Console.WriteLine($"Remolcando {tipoCarga}");
        }

        //En esta clase, como en las otras, podría sobrescribir los métodos de la clase Vehículo.
        
    }
}
