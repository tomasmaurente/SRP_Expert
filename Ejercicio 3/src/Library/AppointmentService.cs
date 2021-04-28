using System;
using System.Text;

/*
    Al ingresar todos los valores a una sola clase sucede que si bien funciona, 
    este es un codigo muy dificil de mantener, actualizar y entender.
    
    El presente codigo no respeta el principio SRP, ya que tiene mas de una razon de cambio: 
    1) Agregarle la edad a un paciente.
    2) Definir la especialidad del doctor.
    3) Crear un ID por consulta.
    4) Crear chequeos nuevos en cada uno de los anteriores puntos.

    Tampoco cumple con el patron expert, porque no existe clase experta en ningun tipo de informacion. 

    Solucion:
    A la hora de tener que agregarle por ejemplo, la edad al paciente, se tiene que cambiar el 
    metodo "CreateAppointment", en cambio si se crease una clase paciente, solo se tendia que cambiar dicha clase, 
    asi para:                           PACIENTE DOCTOR Y CITA
    facilitando la comprension del codigo (SRP) y encapsulando la informacion de este (Expert).  
*/

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
