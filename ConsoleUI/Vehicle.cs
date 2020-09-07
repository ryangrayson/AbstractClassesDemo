using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract(); //Stubbed out method (no implementaton)(no scope)

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

        

    }

}