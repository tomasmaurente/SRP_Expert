﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente pas1 = new Paciente("Steven Jhonson","5555-555-555","53");
            Paciente pas2 = new Paciente("Ralf Manson","5555-555-555","");

            Doctor doc1 = new Doctor("Armand","Oftalmologo");
            Doctor doc2 = new Doctor("Armand","Cirujano");

            Appointment app1 = new Appointment (pas1, doc1, DateTime.Now, "Wall Street");
            Appointment app2 = new Appointment (pas2, doc2, DateTime.Now, "Queen Street");

            Console.WriteLine(app1);
            Console.WriteLine(app2);

            

            /*
            Se manejan niveles de proteccion (encapsulacion) para que la siguiente asignacion no sea permitida
            app1.Doctor = doc2;
            En caso de que se desee poder "setear" el doctor de una instancia de Appointment ya creada
            Se debe implementar el siguiente metodo en la clase "Appointment"
            
            
            public void CambioDeDoctor(Doctor nuevoDoc)
            {
                this.doctor = nuevoDoc;
            }

            */

        }
    }
}
