using System;

/*
    La clase "Libro" no respeta el principio SRP ya que tiene dos responsabilidades:
    1) La de conocer los datos del libro 
    2) La de conocer su lugar en la biblioteca. 
    Para solucionarlo implementariamos otra clase "Estante" que se encargue de la resposabilidad de almacenar.
*/

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}