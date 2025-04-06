using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Ejercicio1
{
    internal class Vehículo
    {
        private string marca;
        private string color;
        private string modelo;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Vehículo(string marca, string color, string modelo)
        {
            this.marca = marca;
            this.color = color;
            this.modelo = modelo;    
        }
    }
}
