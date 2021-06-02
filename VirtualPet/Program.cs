using System;

namespace VirtualPet
{
    class Program
    {
        public static Pet myPet = new Pet();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("What is your pets name? ");
            string Input = Console.ReadLine();
            myPet.SetName(Input);

            //myPet.Name = name;


            Console.WriteLine("What kind of species is your pet? ");
            Input = Console.ReadLine();
            myPet.SetSpecies(Input);
            Console.WriteLine($"Your {myPet.Species}'s name is {myPet.Name}.");

            DisplayMenu();
            

        }
        public static void DisplayMenu()
        {
            bool VirtualPet = true;
            while (VirtualPet)
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
                        //atm.Withdraw();
                        Console.WriteLine("You withdrew $10");
                        break;
                    case "3":
                        //atm.Deposit();
                        Console.WriteLine("You deposited $50");
                        break;
                    case "4":
                        Console.WriteLine("Thank you for banking with us.");
                        VirtualPet = false;
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