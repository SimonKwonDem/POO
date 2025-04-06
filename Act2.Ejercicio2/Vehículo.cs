using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio2
{
    internal class Vehículo
    {
        private string modelo;
        private string marca;
        private string color;
        private int año;
        private string numSerie;
        private string tipoMotor;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
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
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        public string NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }
        public string TipoMotor
        {
            get { return tipoMotor; }
            set { tipoMotor = value; }
        }

        public virtual void EncenderVehículo()
        {
            Console.WriteLine("Encendiendo Vehículo.. ");
        }
        public virtual void DetenerVehículo()
        {
            Console.WriteLine("Deteniendo Vehículo.. ");
        }
        public virtual void AcelerarVehículo()
        {
            Console.WriteLine("Acelerando Vehículo.. ");
        }
        public virtual void FrenarVehículo()
        {
            Console.WriteLine("Frenando Vehículo.. ");
        }
    }
}
