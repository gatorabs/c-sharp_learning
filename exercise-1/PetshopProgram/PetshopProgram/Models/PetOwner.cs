using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopProgram.Models
{
    internal class PetOwner
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = [];


        public PetOwner(string _name, int _age, int _phoneNumber)
        {
            Name = _name;
            Age = _age;
            PhoneNumber = _phoneNumber;

        }
        public void AddPets(Pet _pet, PetOwner _petOwner)
        {

            Console.WriteLine("Adding Pet:");
            Pets.Add(_pet);
            _pet.ReturnPetDescription();

            Console.WriteLine("Adding Owner:");
            ReturnPetOwnerDescription(_petOwner);
            _pet.Owner.Add(_petOwner);


            
        }

        public void ReturnPetOwnerDescription(PetOwner _petOwner)
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age} ");
            Console.WriteLine($"PhoneNumber: {PhoneNumber} ");
            Console.WriteLine("");
            ListAllPets();
            
        }

        public void ListAllPets()
        {
            Console.WriteLine($"Associated Pet with {Name}");
            Console.WriteLine("");
            foreach (Pet pet in Pets)
            {

                pet.ReturnPetDescription();
            }
        }
    }
}
