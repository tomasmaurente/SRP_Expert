using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Estante estante1 = new Estante("A","7");
            Estante estante2 = new Estante("B","3");
            estante1.AlmacenarLibro(libro1);
            estante2.AlmacenarLibro(libro2);

            Console.WriteLine(libro1);

        }
    }
}
