using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Hunger { get; set; }

        public string Boredom { get; set; }
        public string Health { get; set; }

        public Pet()
        {
            Name = "Pet Name";


        }
        public void SetName(string petName) 
        {
            Name = petName;
        }
        
    }
}
