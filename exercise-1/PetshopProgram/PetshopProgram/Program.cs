using PetshopProgram.Models;
using PetshopProgram.Models.Doctor;

var petOwner_Obj = new PetOwner("Gabriel", 20, 19);
var petDoctor_Obj = new PetDoctor("Muzzi", 2000);

var pet_Obj = new Pet("Quelo", "Cachorro", "Vira-Lata", 8);
var pet_Obj_2 = new Pet("Esto", "Cachorro", "Vira-Lata", 11);

petOwner_Obj.AddPets(pet_Obj_2, petOwner_Obj);


//petOwner_Obj.ListAllPets();

//petDoctor_Obj.Realize_appointment(pet_Obj, "Headache");
petDoctor_Obj.Realize_appointment(pet_Obj_2, "Angry");

petDoctor_Obj.ShowDoctorAppointments();
