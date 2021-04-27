using System;

/*

    La clase "Kiosco" no cumple correctamente el principio SRP; 
    ya que tiene la responsabilidad de determinar si se puede comprar un alfajor
    y además tiene la responsabilidad de transformar dolares a pesos, en caso de ser necesario.

    Por otro lado, si nos acercamos a la siguiente definicion del principio SRP
    "Una clase debe tener solo una razón para cambiar",
    podemos encontrar por ejemplo que si en algun momento cambia la formula de el calculo del precio 
    "a.PrecioDulce + a.PrecioMasa"
    y se toma en cuenta por ejemplo el precio del envoltorio, deberiamos recurrir al metodo "PuedeComprar"
    y alterarlo. 
    Ademas, en caso de que el precio de relacion entre el peso y el dolar se altere 
    deberiamos alterar el metodo "ConvertirAPesos".
    Por lo tanto, observamos dos razones de cambio para una sola clase lo que viola el patron SRP.

*/

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}