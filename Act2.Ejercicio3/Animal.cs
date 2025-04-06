using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio3
{
    internal class Animal
    {
        private string especie;
        private int edad;
        private string género;
        private string tamaño;
        private string coberturaCorporal;

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Género
        {
            get { return género; }
            set { género = value; }
        }
        public string Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public string CoberturaCorporal
        {
            get { return coberturaCorporal; }
            set { coberturaCorporal = value; }
        }

        public virtual void Comer()
        {
            Console.WriteLine("El animal se esta alimentando...");
        }
        public virtual void Reproducir()
        {
            Console.WriteLine("El animal se esta reproduciendo..");
        }
        public virtual void SonidoAnimal()
        {
            Console.WriteLine("ruido característico");
        }
    }
 }
