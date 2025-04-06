using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2.Ejercicio5
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private int añoPublicacion;
        private string genero;
        private bool prestado;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int AñoPublicacion
        {
            get { return añoPublicacion; }
            set { añoPublicacion = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public bool Prestado
        {
            get; set;
        } = false;

        public Libro(string titulo, string autor, int añoPublicacion, string genero, bool prestado)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.añoPublicacion = añoPublicacion;
            this.genero = genero;
            this.prestado = false;
        }
    }
}
