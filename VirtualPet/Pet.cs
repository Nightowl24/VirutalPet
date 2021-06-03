using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            Hunger = 50;
            Boredom = 60;
            Health = 30;
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
             return Hunger;
        }

        public void SetBoredom(int boredom)
        {
            Boredom = boredom;
        }

        public int GetBoredom()
        {
            return Boredom;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public int GetHealth()
        {
            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
        }

        public void SeeDoctor()
        {
            Health += 30;
        }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;           
        }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
            Console.WriteLine($"Time has passed, {Name}'s hunger and boredom have increased by 5 and health has decreased by 5. ");
        }

        public void PetStatus()
        {
            Console.Write($"{Name}'s Status\nHealth: {Health} \nHunger: {Hunger} \nBoredom: {Boredom}\n");
        }
    }
}
