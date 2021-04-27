using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Double PrecioDulce {get; set;}
        public Double PrecioMasa {get; set;}
        public Alfajor(double precioMasa, double precioDulce)
        {
            PrecioDulce = precioDulce;
            PrecioMasa = precioMasa;
        }
    
        public double PrecioAlfajor()
        {
            return PrecioDulce + PrecioMasa;
        }

    }
}