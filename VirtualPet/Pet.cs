using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }

        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet()
        {
            Name = "";
            Species = "";
        }

        public void SetName(string name) 
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }
        
        public void SetHunger(int hunger)
        {
            Hunger = hunger;
        }

        public int GetHunger()
        {
            Hunger = 50;
            return Hunger;
        }
        public void SetBoredom(int boredom)
        {
            Boredom = boredom;
        }

        public int GetBoredom()
        {
            Boredom = 60;
            return Boredom;
        }
    }
}
