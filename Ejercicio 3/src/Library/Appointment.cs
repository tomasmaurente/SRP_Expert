using System;

namespace Library
{
    public class Appointment
    {
        private Paciente paciente;
        public string Paciente
        {
            get
            {
                return paciente.ToString();
            }
        }
        private Doctor doctor;
        public string Doctor 
        {
            get
            {
                return doctor.ToString();
            }
        }

        public int Id {get; }
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

        private static int contador_id = 0;

        public Appointment(Paciente paciente, Doctor doctor, DateTime date, string place)
        {
            this.paciente = paciente;
            this.doctor = doctor;
            Date = date;
            Place = place;

            Id = contador_id;
            contador_id=+1;
        }

        public override string ToString()
        {
            return Paciente + " " + Doctor + " " + Id + " " + Date + " " + Place;
        }
    }
}
