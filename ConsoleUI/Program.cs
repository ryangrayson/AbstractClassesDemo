using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle---DONE
             * The vehicle class shall have three string properties Year, Make, and Model---DONE
             * Set the defaults to something generic in the Vehicle class---DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation---DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.---DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle---DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle---DONE
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method---DONE
            */

            // Create a list of Vehicle called vehicles---DONE

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes---DONE
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */


            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCar = true, Make = "HD", Model = "FXRP", Year = 1994 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2019 };
            Vehicle sportCar = new Car() { HasTrunk = false, Make = "Mazda", Model = "Miata", Year = 2011 };







            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sportCar);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make}\nModel: {veh.Model}\nYear: {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("--------------------------------");
            }




            // Call each of the drive methods for one car and one motorcycle



            #endregion            
            Console.ReadLine();
        }
    }
}
