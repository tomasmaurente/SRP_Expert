using System;
using System.Text;

/*
    Al ingresar todos los valores a una sola clase sucede que si bien funciona, 
    este es un codigo muy dificil de mantener y actualizar.
    
    El presente codigo no respeta el patron SRP, ya que tiene mas de una razon de cambio: 
    1)  Agregarle la edad a un paciente.
    2) Definir la especialidad del doctor.
    3) Crear un ID por consulta.
    4) Crear chequeos nuevos en cada uno de los anteriores puntos.

    Tampoco cumple con el principio expert, porque no existe clase experta en ningun tipo de informacion. 

    Solucion:
    A la hora de tener que agregarle por ejemplo, la edad al paciente, se tiene que cambiar el 
    metodo "CreateAppointment", en cambio si se crease una clase paciente, solo se tendia que cambiar dicha clase,
    facilitando la comprension del codigo (SRP) y encapsulando la informacion de este (Expert).  
*/

namespace Library
{
    public class AppointmentService
    {
        private Paciente paciente;
        public Paciente Paciente {get; }
        private Doctor doctor;
        private Doctor Doctor {get; }
        private int id;
        public int Id {get; set;}
        private DateTime date;
        public DateTime Date {get; set; }
        private string place; 
        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    place = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un lugar valido");
                }
            }
        }

        private static int contador = 0;
        public AppointmentService(Paciente paciente, Doctor doctor, string id, DateTime date, string place)
        {
            Paciente = paciente;
            Doctor = doctor;
            Id = contador;
            contador++;
            Date = date;
            Place = place;
        }

        public override string ToString()
        {
            return Paciente + Doctor + Id + Date + Place;
        }
    }
}
