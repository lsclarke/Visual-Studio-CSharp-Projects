using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalManagementProject.Product.Car;

namespace CarRentalManagementProject.Product
{
    internal interface IVehicle
    {
        //Methods to sucessfully create a vehicle in the system for renters to choose from

        int getId { get; }
        string Make { get; }

        string Model { get; }

        long Year { get; }

        int MilesPerGallon { get; }

        long Millage { get; }

        long VehicleIdentificationNumber { get; }

        double Price { get; }
    }
}
