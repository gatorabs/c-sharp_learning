using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopProgram.Models.Doctor
{
    internal class PetDoctor(string _name, int _crm)
    {
        public string Name { get; set; } = _name;
        public int Crm { get; set; } = _crm;
        public List<Appointment> Appointments { get; set; } = [];


        
        public Appointment Realize_appointment(Pet pet, string _description)
        {
            Appointment appointment = new();
            var _pet = pet;

            appointment.Pet = _pet;
            appointment.Description = _description;

            Console.WriteLine("Appointment Successful!");
            Console.WriteLine("");
            
            Appointments.Add(appointment);
            _pet.Appointments.Add(appointment);
            
            return appointment;
        }
        public void ShowDoctorDescription()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CRM: {Crm}");
            Console.WriteLine("");
        }
        public void ShowDoctorAppointments()
        {
            ShowDoctorDescription();

            if( Appointments.Count > 0)
            {
                foreach (var appointment in Appointments)
                {
                    Console.WriteLine("Associated Pet:");
                    appointment.Pet.ReturnPetDescription();
                    Console.WriteLine(appointment.Description);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Without Appointments.");
            }
            
        }
    }
}
