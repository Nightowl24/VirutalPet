using System;
using System.Timers;

namespace VirtualPet
{
    public class Pet
    {
        private static Timer timer;
        private bool isAlive;

        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public bool IsRobot { get; set; }

        public Pet()
        {
            Name = "";
            Species = "";
            Hunger = 50;
            Boredom = 60;
            Health = 30;

            isAlive = true;
            timer = new Timer(30000);
            timer.Enabled = true;
            timer.Elapsed += TimerCallBack;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public virtual void SetSpecies(string species)
        {
            Species = species;
        }

        public virtual string GetSpecies()
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
            if (Hunger >= 100 && isAlive)
            {
                Hunger = 100;

                Console.WriteLine($"YOU STARVED {Name} TO DEATH!!!");
                Console.Title = "Game Over";
                Console.WriteLine(@"
                   ____    _    __  __ _____    _____     _______ ____
                  / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \
                 | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |
                 | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ <
                  \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\

                ");

                Console.WriteLine($"YOU STARVED {Name} TO DEATH!!!....LOSER");
                Console.Beep(1000, 10000);
                isAlive = false;
            }
            else if (Hunger <= 0)
            {
                Hunger = 0;
            }

            if (Health >= 100)
            {
                Health = 100;
            }
            else if (Health <= 0 && isAlive)
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
                isAlive = false;
            }

            if (Boredom >= 100 && isAlive)
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
                isAlive = false;
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

        public virtual void Tick()
        {
            
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
            PetLevels();
        }

        public virtual void PetStatus()
        {
            Console.WriteLine($"{Name}'s Status\nHealth: {Health} \nHunger: {Hunger} \nBoredom: {Boredom}\n");
        }

        private void TimerCallBack(object o, EventArgs e)
        {
            Tick();
        }
    }
}
