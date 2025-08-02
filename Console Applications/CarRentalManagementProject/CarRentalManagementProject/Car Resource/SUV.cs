using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalManagementProject.Product.Car.Interior;

namespace CarRentalManagementProject.Product
{
    internal class SUV : Car, IVehicle
    {
        /// <summary>
        /// SUV contructors that will create a brand new SUV object to be added to the inventory of the rental car system
        /// </summary>

        Interior carInterior;
        Exterior carExterior;

        public SUV() { }

        public SUV(string make, string model, long year, int mpg, long millage, long vin, double price, 
            int seatCount, int seatMaterialNum, int seatColor, bool hasWarmers, bool hasNav, bool hasAux, 
            int carMaterialNum, int carColorNum, int wheelGradeNum, bool hasDashCam, bool hasBumperCam, bool hasSideCam, bool hasSpoiler, bool hasTinted)
        {
            carInterior = new Interior(seatCount, seatMaterialNum, seatColor, hasWarmers, hasNav, hasAux);
            carExterior = new Exterior(carMaterialNum, carColorNum, wheelGradeNum, hasDashCam, hasBumperCam, hasSideCam, hasSpoiler, hasTinted);

            var newCar = new Car(carInterior, carExterior);

            ///Below are all the vehicle identification details for the car the customer!
            Make = make;
            Model = model;
            Year = year;
            MilesPerGallon = mpg;
            Millage = millage;
            VehicleIdentificationNumber = vin;
            Price = price;

        }

        /// <summary>
        /// Identification details from the IVehicle interface these functions will store all the important car id details on the paper work and reciept
        /// </summary>

        public string Make { get;}

        public int MilesPerGallon { get; }

        public long Millage { get; }

        public string Model { get; }

        public long Year { get; }

        public long VehicleIdentificationNumber { get; }

        public double Price { get; }

        public int getId { get { return nextId; } }

        public void Display()
        {
            // Display all advanced car details about specific SUV object
            Console.WriteLine($"----------Car No.{getId} Details----------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Type:: SUV, Make:: {Make}, Model:: {Model}");
            Console.WriteLine($"Year:: {Year}, Miles Per Gallon:: {MilesPerGallon}, Millage:: {Millage}");
            Console.WriteLine($"Vehicle Identification Number:: {VehicleIdentificationNumber}");

        }

    }
}
