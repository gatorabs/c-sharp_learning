using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetshopProgram.Models.Doctor
{
    internal class Appointment
    {
        private string _description = string.Empty;


        public string Description
        {
            get => _description;
            set
            {
                _description = $"Description: {value}";
            }
        }

        public Pet? Pet { get; set; }
    }
}
