using System;

namespace VirtualPet
{
    class Program
    {
        public static Pet myPet = new Pet();
        static void Main(string[] args)
        {
            // TODO: Check off stuff on GitHub list
            // TODO: figure out tick()
            Console.WriteLine("Hello! Welcome to Virtual Pets");        
            Console.WriteLine("What is your pets name? ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("The name can't be empty!  Please enter a name: ");
                input = Console.ReadLine();
            }
            myPet.SetName(input);

            //myPet.Name = name;

            Console.WriteLine("What kind of species is your pet? ");    
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("The name can't be empty!  Please enter a species: ");
                input = Console.ReadLine();
            }
            myPet.SetSpecies(input);
            Console.WriteLine($"Your {myPet.Species}'s name is {myPet.Name}.");
            Console.WriteLine("Press any key to continue");         
            Console.ReadKey();

            DisplayMenu();
            

        }
        public static void DisplayMenu()
        {
            bool virtualPet = true;
            while (virtualPet)
            {
                Console.Clear();
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Pet Status");
                Console.WriteLine("2. Feed your pet");
                Console.WriteLine("3. Take pet to the doctor");
                Console.WriteLine("4. Play with pet");
                Console.WriteLine("5. Change pet name");
                Console.WriteLine("6. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        myPet.PetStatus();
                        break;
                    case "2":
                        myPet.Feed();
                        Console.WriteLine($"{myPet.GetName()}'s hunger has decreased by 40.");
                        Console.WriteLine($"Your pet's hunger level is now: {myPet.GetHunger()}");
                        break;
                    case "3":
                        myPet.SeeDoctor();
                        Console.WriteLine($"{myPet.GetName()} is feeling better now.");
                        Console.WriteLine($"Your pet's health level is now: {myPet.GetHealth()}");
                        break;
                    case "4":
                        myPet.Play();
                        Console.WriteLine($"{myPet.GetName()} loves to play!");
                        Console.WriteLine($"Your pet's boredom has decreased to {myPet.GetBoredom()}, " +
                            "and their health and hunger have increased.");
                        break;
                    case "5":
                        Console.WriteLine($"That's terrific, {myPet.GetName()} was a REALLY bad name!  What name would you like: ");
                        string input = Console.ReadLine();
                        myPet.SetName(input);
                        Console.WriteLine($"Your {myPet.GetSpecies()}'s name is now {myPet.GetName()}.  A much better choice, if you ask me.");
                        break;
                    case "6":
                        Console.WriteLine("Thank you for playing Virtual Pets");
                        virtualPet = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }
        }
    }
}