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
        private static int _interiorNumSelection;
        private static int _exteriorNumSelection;
        public SUV() 
        {

        }

        public SUV(string make, string model, long year, int mpg, long millage, long vin, double price, int interiorNum, int extriorNum)
        {
            _interiorNumSelection = interiorNum; 
            _exteriorNumSelection = extriorNum;

            var newCar = new Car(accessInterior(interiorNum), accessExterior(extriorNum));

            ///Below are all the vehicle identification details for the car the customer!
            Make = make;
            Model = model;
            Year = year;
            MilesPerGallon = mpg;
            Millage = millage;
            VehicleIdentificationNumber = vin;
            Price = price;

        }

        public Interior accessInterior(int interiorNum)
        {
            //default initialized value
            var carInterior = new Interior(0,0,0,false,false,false);
            //Different Interior Car features
            switch (interiorNum)
            {
                case 0:
                    carInterior = new Interior(8, 1, 4, true, true, true);
                    break;
                case 1:
                    carInterior = new Interior(6, 3, 2, false, true, true);
                    break;
                case 2:
                    carInterior = new Interior(8, 5, 3, true, true, false);
                    break;
            }
                return carInterior;
        }

        public Exterior accessExterior(int exteriorNum)
        {
            //default initialized value
            var carExterior = new Exterior(0,0,0, false, false, false, false, false);
            //Different Exterior Car features
            switch (exteriorNum)
            {
                case 0:
                    carExterior = new Exterior(1, 4, 95, true, false, false, true, true);
                    break;
                case 1:
                    carExterior = new Exterior(2, 6, 81, false, true, false, false, true);
                    break;
                case 2:
                    carExterior = new Exterior(2, 3, 76, true, false, true, true, false);
                    break;
                case 3:
                    carExterior = new Exterior(3, 4, 74, true, true, true, false, true);
                    break;
            }
            return carExterior;
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

            var interior = accessInterior(_interiorNumSelection);
            var exterior = accessExterior(_exteriorNumSelection);

            Console.WriteLine($"----------Car No.{getId} Details----------");
            Console.WriteLine($"Type:: SUV, Make:: {Make}, Model:: {Model}");
            Console.WriteLine($"Year:: {Year}, Miles Per Gallon:: {MilesPerGallon}, Millage:: {Millage}");
            Console.WriteLine($"Vehicle Identification Number:: {VehicleIdentificationNumber}\n");

            Console.WriteLine($"  ** Interior Features  **");
            Console.WriteLine($"Seats:: {interior.numberOfSeats}, Seat Material:: {interior.getSeatMaterial(interior.seatMaterialText)}, Seat Color:: {interior.getSeatColor(interior.seatColorText)}");
            Console.WriteLine($"Seat Warmers:: {interior.hasSeatWarmers().ToString()}, GPS Navigation System:: {interior.hasGPSNavigation().ToString()}, Auxillary Port:: {interior.hasAuxPort().ToString()}\n");

            Console.WriteLine($"  ** Exterior Features  **");
            Console.WriteLine($"Car Material:: {exterior.getCarMaterial(exterior.carBodyMaterialText)}, Car Color:: {exterior.getCarColor(exterior.carColorText)}, Wheel Grade:: {exterior.checkWheelQuality(exterior.carWheelText)}");
            Console.WriteLine($"Dash Camera:: {exterior.hasDashCamera().ToString()}, Bumper Camera:: {exterior.hasBumperCamera().ToString()}, Side Cameras:: {exterior.hasSideWindowCamera().ToString()}");
            Console.WriteLine($"Spoiler:: {exterior.hasSpoilerOnCar().ToString()}, Tinted Windows:: {exterior.hasTintedWindows().ToString()}\n");
        }

    }
}
