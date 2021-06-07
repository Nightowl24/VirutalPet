using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class RoboPet : Pet
    {
        public int BatteryLife { get; set; }
        public int Repair { get; set; }
        
        public RoboPet()
        {
            BatteryLife = 50;
            Repair = 20;

        }

        public void Charge()
        {
            BatteryLife += 20;
        }

        public void Maintenance()
        {
            Repair -= 30;
        }

        public override void Tick()
        {
            
            Repair += 5;
            Boredom += 5;
            BatteryLife -= 5;
            PetLevels();
        }
        public override void PetStatus()
        {
            Console.WriteLine($"{Name}'s Status\nBattery Life: {BatteryLife} \nRepair: {Repair} \nBoredom: {Boredom}\n");
        }


    }
}
