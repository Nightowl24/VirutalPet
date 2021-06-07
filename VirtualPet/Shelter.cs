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

        public void PlayAll()
        {
            foreach (var pet in ShelterPets)
            {
                pet.Play();
            }
        }

        public void SeeDoctorAll()
        {
            foreach (var pet in ShelterPets)
            {
                pet.SeeDoctor();
            }
        }

        public void FeedAll()
        {
            foreach (var pet in ShelterPets)
            {
                pet.Feed();
            }
        }

        public void PetList()
        {
            foreach (var pet in ShelterPets)
            {
                pet.PetStatus();
            }
        }

        public Pet GetPet(string name)
        {
            return ShelterPets.First(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        }
    }
}