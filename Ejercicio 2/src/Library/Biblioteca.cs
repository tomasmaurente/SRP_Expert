using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SRP
{
    public class Estante
    {
        private string sectorBiblioteca;
        public string SectorBiblioteca { 
            get
            {
                return SectorBiblioteca;
            } 
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    sectorBiblioteca = value;
                }
            }
        }
        private string estanteBiblioteca;
        public string EstanteBiblioteca 
        {
            get
            {
                return estanteBiblioteca;
            }
            set
            {
                estanteBiblioteca = value;
            }
        }
        private List<Libro> libros;
        public ReadOnlyCollection<Libro> Libros
        {
            get
            {
                return this.libros.AsReadOnly();
            }
        }

        public Estante(String sectorBiblioteca, String estanteBiblioteca)
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
