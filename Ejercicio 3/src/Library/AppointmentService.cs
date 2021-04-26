using System;
using System.Text;

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
