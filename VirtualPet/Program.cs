using System;
using System.Linq;

namespace VirtualPet
{
    internal class Program
    {
        public static Shelter myShelter = new Shelter();

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets' Shelter");

            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            bool virtualPet = true;
            while (virtualPet)
            {
                Pet myPet = new Pet();


                Console.WriteLine("\nWhat would you like to do?");

                Console.WriteLine("1. Admit Pet");
                Console.WriteLine("2. Pet List");
                Console.WriteLine("3. Pet Status");
                Console.WriteLine("4. Feed your pet");
                Console.WriteLine("5. Take pet to the doctor");
                Console.WriteLine("6. Play with pet");
                Console.WriteLine("7. Change pet name");
                Console.WriteLine("8. Adopt a pet");
                Console.WriteLine("9. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("Is this pet Robotic? Y/N ");
                        string input = Console.ReadLine().ToUpper();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("The name can't be empty!  Please try again. ");
                            input = Console.ReadLine();
                        }
                        if (input == "Y")

                        {
                            myPet = new RoboPet();
                            myPet.IsRobot = true;
                            
                        }
                        else
                        {
                            myPet = new Pet();
                            myPet.IsRobot = false;
                            
                        }

                        Console.WriteLine("What is your pet's name? ");
                            input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("The name can't be empty!  Please enter a name: ");
                            input = Console.ReadLine();
                        }
                        myPet.SetName(input);

                        Console.WriteLine("What kind of species is your pet? ");
                        input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("The name can't be empty!  Please enter a species: ");
                            input = Console.ReadLine();
                        }
                        myPet.SetSpecies(input);


                        string str = myPet.IsRobot ? $"Your Robotic {myPet.Species}'s name is {myPet.Name}." :  $"Your Real {myPet.Species}'s name is {myPet.Name}.";
                        Console.WriteLine(str);
                        myShelter.AdmitPet(myPet);
                        break;


                    case "2":
                        myShelter.PetList();
                        break;

                    case "3":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");

                        Console.WriteLine("Which pet would you like to get the status of: ");
                        input = Console.ReadLine();
                        Pet petToCheck = myShelter.GetPet(input);
                        petToCheck.PetStatus();
                        break;

                    case "4":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");
                        Console.WriteLine("Which pet would you like to feed ('all' to feed all): ");
                        input = Console.ReadLine();
                        if (input.Equals("all", StringComparison.OrdinalIgnoreCase))
                        {
                            myShelter.FeedAll();
                            Console.WriteLine("You have fed all the animals.");
                            myShelter.PetList();
                        }
                        else 
                        {
                            Pet petToFeed = myShelter.GetPet(input);
                            petToFeed.Feed();
                            Console.WriteLine($"{petToFeed.GetName()}'s hunger has decreased by 40.");
                            Console.WriteLine($"Your pet's hunger level is now: {petToFeed.GetHunger()}");
                        }
                        break;

                    case "5":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");
                        Console.WriteLine("Which pet would you like to see the doctor ('all' to play with all): "); 
                        input = Console.ReadLine();
                        if (input.Equals("all", StringComparison.OrdinalIgnoreCase))
                        {
                            myShelter.SeeDoctorAll();
                            Console.WriteLine("All pets have been seen by the doctor.");
                            myShelter.PetList();
                        }
                        else 
                        { 
                        Pet petToSeeDoctor = myShelter.GetPet(input);
                        petToSeeDoctor.SeeDoctor();
                        Console.WriteLine($"{petToSeeDoctor.GetName()} is feeling better now.");
                        Console.WriteLine($"Your pet's health level is now: {petToSeeDoctor.GetHealth()}");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");
                        Console.WriteLine("Which pet would you like to play with ('all' to play with all): ");
                        input = Console.ReadLine();
                        if (input.Equals("all", StringComparison.OrdinalIgnoreCase))
                        {
                            myShelter.PlayAll();
                            Console.WriteLine("You are playing with all animals.");
                            myShelter.PetList();
                        }
                        else
                        {
                            Pet petToPlay = myShelter.GetPet(input);
                            petToPlay.Play();
                            Console.WriteLine($"{petToPlay.GetName()} loves to play!");
                            Console.WriteLine($"Your pet's boredom has decreased to {petToPlay.GetBoredom()}, " +
                                "and their health and hunger have increased.");
                        }
                        break;

                    case "7":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");
                        Console.WriteLine("Which pet would you like to rename: ");
                        input = Console.ReadLine();
                        Pet petToRename = myShelter.GetPet(input);
                        Console.WriteLine($"That's terrific, {input} was a REALLY bad name!  What name would you like: ");
                        input = Console.ReadLine();                   
                        petToRename.SetName(input);
                        Console.WriteLine($"This pet's name is now {petToRename.GetName()}.  A much better choice, if you ask me.");
                        break;

                    case "8":
                        Console.WriteLine($"Available pets: {string.Join(", ", myShelter.ShelterPets.Select(x => x.Name))}");
                        Console.WriteLine("Which pet would you like to adopt: ");
                        input = Console.ReadLine();
                        Pet petToAdopt = myShelter.GetPet(input);
                        myShelter.AdoptPet(petToAdopt);
                        Console.WriteLine($"Thank you for adopting {petToAdopt.GetName()}!");
                        break;

                    case "9":
                        Console.WriteLine("Thank you for playing Virtual Pets");
                        virtualPet = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}