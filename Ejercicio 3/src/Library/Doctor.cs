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
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un nombre");
                }
            }
        }
        private string especialidad;
        public string Especialidad 
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.especialidad = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una especialidad");
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