using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio3
{
    internal class Perro:Animal
    {
        private string raza;
        private string patrónPelaje;
        private string temparamento;
        private string piruetaAprendida;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public string PatrónPelaje
        {
            get { return patrónPelaje; }
            set { patrónPelaje = value; }
        }
        public string Temparamento
        {
            get { return temparamento; }
            set { temparamento = value; }
        }
        public string PiruetaAprendida
        {
            get { return piruetaAprendida; }
            set { piruetaAprendida = value; }
        }
        public void RealizarPirueta()
        {
            Console.WriteLine($"El perro sabe {piruetaAprendida}");
        }
        public void OlfatearRastro()
        {
            Console.WriteLine("El perro se encuentra olfateando un rastro");
        }
        public override void Comer()
        {
            Console.WriteLine("El perro se encuentra comiendo..");
        }
        public override void Reproducir()
        {
            Console.WriteLine("El perro se reproduce...");
        }
        public override void SonidoAnimal()
        {
            Console.WriteLine("guau guau");
        }
    }
}
