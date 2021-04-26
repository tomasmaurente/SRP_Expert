using System;

namespace Library
{
    public class Appointment
    {
        public Paciente Paciente{get; }
        private Doctor Doctor {get; }

        private int id;
        public int Id 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

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
                    place = "SIN ESPECIFICAR";
                }
            }
        }

        private static int contador = 0;

        public Appointment(Paciente paciente, Doctor doctor, DateTime date, string place)
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
            return Paciente.ToString() + " " + Doctor.ToString() + " " + Id.ToString() + " " + Date + " " + Place;
        }
    }
}
