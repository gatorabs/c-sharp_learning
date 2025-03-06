using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetshopProgram.Models.Doctor;

namespace PetshopProgram.Models
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Specie { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public List<PetOwner> Owner { get; set; } = [];
        public List<Appointment> Appointments { get; set; } = [];

        public Pet(string _name, string _specie, string _race, int _age)
        {
            Name = _name;
            Specie = _specie;
            Race = _race;
            Age = _age;
        }


        public void ReturnPetAppointments()
        {
            ReturnPetDescription();
            foreach (Appointment appointment in Appointments)
            {
                Console.WriteLine(appointment.Description);
            }

        }

        public void ReturnPetDescription()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"Specie: {Specie} ");
            Console.WriteLine($"Race: {Race} ");
            Console.WriteLine("");

        }
    }
}
