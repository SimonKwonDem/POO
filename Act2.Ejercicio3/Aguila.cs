using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio3
{
    internal class Aguila: Animal
    {
        private string patrónPlumaje;
        private string tipoPlumaje;
        private string dieta;

        public string PatrónPlumaje
        {
            get { return patrónPlumaje; }
            set { patrónPlumaje = value; }
        }
        public string TipoPlumaje
        {
            get { return tipoPlumaje; }
            set { tipoPlumaje = value; }
        }
        public string Dieta
        {
            get { return dieta; }
            set { dieta = value; }
        }

        public void Cazar()
        {
            Console.WriteLine("El águila se encuentra cazando...");
        }
        public override void Comer()
        {
            Console.WriteLine("El águila se encuentra comiendo..");
        }
        public override void Reproducir()
        {
            Console.WriteLine("El águila se esta reproduciendo..");
        }
        public override void SonidoAnimal()
        {
            Console.WriteLine("kak.. kak..");
        }
    }
}
