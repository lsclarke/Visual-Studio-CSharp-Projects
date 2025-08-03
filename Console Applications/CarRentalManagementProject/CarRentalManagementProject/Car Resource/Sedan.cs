using CarRentalManagementProject.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalManagementProject.Product.Car;
using static CarRentalManagementProject.Product.Car.Interior;

namespace CarRentalManagementProject.Car_Resource
{
    internal class Sedan : Car, IVehicle
    {
        /// <summary>
        /// SUV contructors that will create a brand new SUV object to be added to the inventory of the rental car system
        /// </summary>
        private static int _interiorNumSelection;
        private static int _exteriorNumSelection;

        public static int id = 0;

        public static int getCarID() => id;
        public Sedan()
        {

        }

        public Sedan(string make, string model, long year, int mpg, long millage, long vin, double price, int interiorNum, int extriorNum)
        {
            _interiorNumSelection = interiorNum;
            _exteriorNumSelection = extriorNum;
            id++;
            var interior = accessInterior(interiorNum);
            var exterior = accessExterior(extriorNum);

            Car newCar = new Car(2, interior, exterior);

            ///Below are all the vehicle identification details for the car the customer!
            Make = make;
            Model = model;
            Year = year;
            MilesPerGallon = mpg;
            Millage = millage;
            VehicleIdentificationNumber = vin;
            Price = price;

            Display();

        }

        public Interior accessInterior(int interiorNum)
        {
            //default initialized value
            var carInterior = new Interior(0, 0, 0, false, false, false);
            //Different Interior Car features
            switch (interiorNum)
            {
                case 0:
                    carInterior = new Interior(4, 1, 1, true, true, true);
                    break;
                case 1:
                    carInterior = new Interior(5, 2, 3, false, false, true);
                    break;
                case 2:
                    carInterior = new Interior(4, 5, 2, true, false, false);
                    break;
            }
            return carInterior;
        }

        public Exterior accessExterior(int exteriorNum)
        {
            //default initialized value
            var carExterior = new Exterior(0, 0, 0, false, false, false, false, false);
            //Different Exterior Car features
            switch (exteriorNum)
            {
                case 0:
                    carExterior = new Exterior(2, 2, 84, true, false, false, true, true);
                    break;
                case 1:
                    carExterior = new Exterior(1, 6, 88, false, true, true, false, false);
                    break;
                case 2:
                    carExterior = new Exterior(2, 3, 65, true, false, true, true, false);
                    break;
                case 3:
                    carExterior = new Exterior(3, 4, 74, false, false, true, false, true);
                    break;
            }
            return carExterior;
        }

        /// <summary>
        /// Identification details from the IVehicle interface these functions will store all the important car id details on the paper work and reciept
        /// </summary>
        public string Make { get; }

        public int MilesPerGallon { get; }

        public long Millage { get; }

        public string Model { get; }

        public long Year { get; }

        public long VehicleIdentificationNumber { get; }

        public double Price { get; }

        public int getId { get { return nextId; } }

        public int UpdateId(int num)
        {
            nextId = num;
            return nextId;
        }

        public double CalculateTotalPrice(int days, double price)
        {
            double extraFee = 20.15;
            double Total = (days * price);
            var interior = accessInterior(_interiorNumSelection);
            var exterior = accessExterior(_exteriorNumSelection);

            //interior fees
            if (interior.hasSeatWarmers())
                Total += 20.15;
            if (interior.hasAuxPort())
                Total += 20.15;
            if (interior.hasGPSNavigation())
                Total += 20.15;

            //exterior fess
            if (exterior.hasDashCamera())
                Total += 20.15;
            if (exterior.hasSideWindowCamera())
                Total += 20.15;
            if (exterior.hasBumperCamera())
                Total += 20.15;
            if (exterior.hasSpoilerOnCar())
                Total += 20.15;
            if (exterior.hasTintedWindows())
                Total += 20.15;

            //Display fees if they are applied to this suv instances
            //if (interior.hasSeatWarmers())
            //    Console.WriteLine($"Seat Warmers:: {interior.hasSeatWarmers().ToString()} +${extraFee}");
            //if (interior.hasGPSNavigation())
            //    Console.WriteLine($"GPS Navigation System:: {interior.hasGPSNavigation().ToString()} +${extraFee}");
            //if (interior.hasAuxPort())
            //    Console.WriteLine($"Auxillary Port:: {interior.hasAuxPort().ToString()} +${extraFee}");

            //if (exterior.hasDashCamera())
            //    Console.WriteLine($"Dash Camera:: {exterior.hasDashCamera().ToString()} +${extraFee}");
            //if (exterior.hasBumperCamera())
            //    Console.WriteLine($"Bumper Camera:: {exterior.hasBumperCamera().ToString()} +${extraFee}");
            //if (exterior.hasSideWindowCamera())
            //    Console.WriteLine($"Side Camera:: {exterior.hasSideWindowCamera().ToString()} +${extraFee}");

            //if (exterior.hasSpoilerOnCar())
            //    Console.WriteLine($"Spoiler Port:: {exterior.hasSpoilerOnCar().ToString()} +${extraFee}");
            //if (exterior.hasTintedWindows())
            //    Console.WriteLine($"Tinted Windows:: {exterior.hasTintedWindows().ToString()} +${extraFee}\n");

            return Total;
        }
        public void Display()
        {
            // Display all advanced car details about specific SUV object
            var interior = accessInterior(_interiorNumSelection);
            var exterior = accessExterior(_exteriorNumSelection);


            Console.WriteLine($"----------Car No.{getId} Details----------");
            Console.WriteLine($"  **  Price per day: ${Price}  **");
            Console.WriteLine($"-----------------------------------\n");
            Console.WriteLine($"Type:: Sedan , Make:: {Make}, Model:: {Model}");
            Console.WriteLine($"Year:: {Year}, Miles Per Gallon:: {MilesPerGallon}, Millage:: {Millage}");
            Console.WriteLine($"Vehicle Identification Number:: {VehicleIdentificationNumber}\n");

            Console.WriteLine($"  **  Interior Features  **");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Seats:: {interior.numberOfSeats}, Seat Material:: {interior.getSeatMaterial(interior.seatMaterialText)}, Seat Color:: {interior.getSeatColor(interior.seatColorText)}");
            Console.WriteLine($"Seat Warmers:: {interior.hasSeatWarmers().ToString()}, GPS Navigation System:: {interior.hasGPSNavigation().ToString()}, Auxillary Port:: {interior.hasAuxPort().ToString()}\n");

            Console.WriteLine($"  **  Exterior Features  **");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Car Material:: {exterior.getCarMaterial(exterior.carBodyMaterialText)}, Car Color:: {exterior.getCarColor(exterior.carColorText)}, Wheel Grade:: {exterior.checkWheelQuality(exterior.carWheelText)}");
            Console.WriteLine($"Dash Camera:: {exterior.hasDashCamera().ToString()}, Bumper Camera:: {exterior.hasBumperCamera().ToString()}, Side Cameras:: {exterior.hasSideWindowCamera().ToString()}");
            Console.WriteLine($"Spoiler:: {exterior.hasSpoilerOnCar().ToString()}, Tinted Windows:: {exterior.hasTintedWindows().ToString()}");
            Console.WriteLine($"-----------------------------------\n");


        }
    }
}
