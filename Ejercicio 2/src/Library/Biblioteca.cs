using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SRP
{
    public class Biblioteca
    {

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        private List<Libro> libros;
        public ReadOnlyCollection<Libro> Libros
        {
            get
            {
                return this.libros.AsReadOnly();
            }
        }

        public Biblioteca(String sectorBiblioteca, String estanteBiblioteca)
        {
            SectorBiblioteca = sectorBiblioteca;
            EstanteBiblioteca = estanteBiblioteca;
            this.libros = new List<Libro> {};
        }

        public void AlmacenarLibro(Libro nuevo)
        {
            this.libros.Add(nuevo);
        }

        public override string ToString()
        {
            return "Sector: " + SectorBiblioteca + ", Estante: " + EstanteBiblioteca;
        }
    }
}
