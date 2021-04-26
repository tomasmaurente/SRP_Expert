using System;
using System.Text;

namespace Library
{
    
    public class Paciente
    {
        // Variable de clase para asignar Id
        private static int Contador_id = 0;

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

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un numero de celular/telefono");
                }
            }
        }
        
        private string age;
        public string Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una edad");
                }
            }
        }
        
        private int id;
        public int Id 
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

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
            return "El/La paciente "+ Name +", tiene un id de "+Id;
        }

    }
}
