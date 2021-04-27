using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca estante1 = new Biblioteca("A","7");
            Biblioteca estante2 = new Biblioteca("B","3");
            estante1.AlmacenarLibro(libro1);
            estante2.AlmacenarLibro(libro2);

            Console.WriteLine(libro1);

        }
    }
}
