using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Shelter : Pet
        
        
    {       

        public List<Pet> ShelterPets = new List<Pet>();
        public void AdmitPet(Pet pet)
        {
            ShelterPets.Add(pet);
        } 

        public void AdoptPet(Pet pet)
        {
            ShelterPets.Remove(pet);
        }

        public void Playall()
        {
            foreach(var pet in ShelterPets)
            {
                pet.Play();
            }
        }
    }
}
