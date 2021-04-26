using System;
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
        }
    }
}
