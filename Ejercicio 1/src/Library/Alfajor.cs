using System;

/*
    La clase "Alfajor" cumple correctamente las indicaciones del principio Expert, 
    asigna la responsabilidad del Constructor al que posee la informacion, las variables de instancia.
    Si una crítica se puede hacer es que no aprovecha sus beneficios, no matiene encapsulada la clase.

    El patron SRP se cumple; ya que unicamente tiene la responsabilidad de crear y asignar 
    las variables de instancia.
*/

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}