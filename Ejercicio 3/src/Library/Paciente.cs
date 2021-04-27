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
                }
            }
        }

        public int Id {get; }

        // Variable de clase para asignar el Id
        private static int contador_id = 0;
        
        public Paciente (string name, string phoneNumber, string age)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age; 
            
            Id = contador_id;
            contador_id += 1;
        }

        public override string ToString()
        {
            return Id +" "+ Name +" "+ Age +" "+ PhoneNumber;
        }

    }
}
