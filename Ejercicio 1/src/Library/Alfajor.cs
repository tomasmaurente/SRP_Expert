using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        private Double precioDulce;
        public Double PrecioDulce {get;set;}
        private Double precioMasa;
        public Double PrecioMasa {get; set;}
        public Alfajor(double precioMasa, double precioDulce)
        {
            PrecioDulce = precioDulce;
            PrecioMasa = precioMasa;
        }
    
    }
}