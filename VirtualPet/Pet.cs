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
            PetLevels();
            return Hunger;
        }

        public void SetBoredom(int boredom)
        {
            Boredom = boredom;
        }

        public int GetBoredom()
        {
            PetLevels();
            return Boredom;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public int GetHealth()
        {
            PetLevels();
            return Health;
        }

        public void PetLevels()
        {
            if (Hunger >= 100)
            {
                Hunger = 100;
                Console.WriteLine($"YOU STARVED {Name} TO DEATH!!!");
                //Console.Beep(1000, 10000);
                Console.Title = "Game Over";
                Console.WriteLine(@"
                   ____    _    __  __ _____    _____     _______ ____  
                  / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ 
                 | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                 | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < 
                  \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\
                                                        

                ");
            }
            else if (Hunger <= 0)
            {
                Hunger = 0;
            }
            
            if (Health >= 100)
            {
                Health = 100;
            }
            else if (Health <= 0)
            {
                Health = 0;
                Console.WriteLine($"YOU KILLED {Name}!!!");
                Console.Title = "Game Over";
                Console.WriteLine(@"
                   ____    _    __  __ _____    _____     _______ ____  
                  / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ 
                 | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                 | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < 
                  \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\
                                                        

                ");
            }

            if (Boredom >= 100)
            {
                Boredom = 100;
                Console.WriteLine($"YOU KILLED {Name} WITH YOUR BORING WAYS!!!");
                Console.Title = "Game Over";
                Console.WriteLine(@"
                   ____    _    __  __ _____    _____     _______ ____  
                  / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ 
                 | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                 | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < 
                  \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\
                                                        

                ");
            }
            else if (Boredom <= 0)
            {
                Boredom = 0;
            }
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
            PetLevels();
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
            //Console.WriteLine($"Time has passed, {Name}'s hunger and boredom have increased by 5 and health has decreased by 5. ");
        }

        public void PetStatus()
        {
            Console.Write($"{Name}'s Status\nHealth: {Health} \nHunger: {Hunger} \nBoredom: {Boredom}\n");
        }

    }
}
