﻿using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public override string ToString()
        {
            return "Titulo: " + Titulo + ", Autor: " + Autor + ", Codigo: " + Codigo;
        }
    }
}
