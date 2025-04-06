using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio5
{
    internal class Biblioteca
    {
        private string nombre;
        private string ubicacion;
        private string horarioApertura;
        private string horarioCierre;
        private List<Libro> libros;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string HorarioApertura
        {
            get { return horarioApertura; }
            set { horarioApertura = value; }
        }
        public string HorarioCierre
        {
            get { return horarioCierre; }
            set { horarioCierre = value; }
        }
        public List<Libro> Libros
        {
            get { return libros; }
            private set { libros = value; }
        }

        //Constructor
        public Biblioteca(string nombre, string ubicacion, string horarioApertura, string horarioCiere)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.horarioApertura = horarioApertura;
            this.horarioCierre = horarioCiere;
            Libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libroNuevo)
        {
                Libros.Add(libroNuevo);
        }
        public Libro BuscarLibro(string titulo)
        {
            foreach (Libro libroBuscado in Libros)
            {
                if(string.Equals(libroBuscado.Titulo,titulo,StringComparison.OrdinalIgnoreCase))
                {
                    return libroBuscado;
                }
            }
            return null;
        }

        public void PrestarLibro(string titulo)
        {
            Libro libro = BuscarLibro(titulo);
            if(libro == null)
            {
                Console.WriteLine("El libro no se encuentra en la biblioteca");
                return;
            }
            if(libro.Prestado)
            {
                Console.WriteLine("El libro se encuentra prestado");
            }
            else
            {
                libro.Prestado = true;
                Console.WriteLine("Libro prestado con éxito");
            }
        }

        public void MostrarLibros()
        {
            foreach(Libro librosActuales in Libros)
            {
                Console.WriteLine($"Titulo:{librosActuales.Titulo} | Prestado: {(librosActuales.Prestado ? "si" : "no")}");
            }
        }



    }
}
