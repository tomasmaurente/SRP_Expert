using System;

namespace Library
{
    
    public class Doctor
    {

        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un nombre valido");
                    name = "SIN ESPECIFICAR";
                }
            }
        }

        private string especialidad;
        public string Especialidad 
        {
            get
            {
                return especialidad;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    especialidad = value;
                }
                else
                { 
                    Console.WriteLine("Debe ingresar una especialidad valida");
                    especialidad = "SIN ESPECIFICAR";
                }
            }
        }

        public Doctor(string name, string especialidad)
        {
            Name = name;
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return Name +" "+ Especialidad;
        }
    }
        
}