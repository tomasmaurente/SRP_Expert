using System;

namespace Library
{
    
    public class Paciente
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
        
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero de celular o telefono valido");
                    phoneNumber = "SIN ESPECIFICAR";
                }
            }
        }
        
        private string age;
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una edad valida");
                    age = "SIN ESPECIFICAR";
                }
            }
        }

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

        // Variable de clase para asignar Id
        private static int Contador_id = 0;
        
        public Paciente (string name, string phoneNumber, string age)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age; 
            Id = Contador_id;
            Contador_id += 1;
        }

        public override string ToString()
        {
            return Id +" "+ Name +" "+ Age +" "+ PhoneNumber;
        }

    }
}
