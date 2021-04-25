using System;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        public List<Libro> Libros {get ; set;}

        public Biblioteca(String sectorBiblioteca, String estanteBiblioteca)
        {
            this.SectorBiblioteca = sectorBiblioteca;
            this.EstanteBiblioteca = estanteBiblioteca;
            this.Libros = new List<Libro> {};
        }

        public void AlmacenarLibro(Libro nuevo)
        {
            this.Libros.Add(nuevo);
            nuevo.Ubicacion = this;
        }

        public override string ToString()
        {
            return "Sector: " + SectorBiblioteca + ", Estante: " + EstanteBiblioteca;
        }
    }
}
