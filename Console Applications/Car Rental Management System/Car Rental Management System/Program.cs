using System.Collections.Generic;
using System.Xml.Linq;
using static Inventory;

namespace Car_Rental_Management_System
{
    internal class Program
    {
        /// <summary>
        /// In the main method I create a dictionary collection for all the vehicles and also added an inventory objevt var and struct associated with it to access all the inputs
        /// </summary>
        static void Main(string[] args)
        {
            Dictionary<int, Car> Vehicles = new Dictionary<int, Car>();
            
            Inventory _Inventory = new Inventory(Vehicles);
            InventoryInputs _Inputs = new InventoryInputs();

            DisplayInventoryData _InventoryData;
            _InventoryData = _Inventory.DisplayCarDetails;

            // Car Rental System Prompts Below//
            //1
            Console.WriteLine("Car Rental Management System\n");
            _InventoryData.Invoke(Vehicles, _Inputs);
            //2
            Console.Write("\nPlease enter the number of days you wish to rent one of our vehicles: ");
            _Inputs.DaysNumber = int.Parse(Console.ReadLine());
            //3
            Console.Write("\nPlease enter the car number (No.#) to choose the car you wish to rent: ");
            _Inputs.CarNumber = int.Parse(Console.ReadLine());
            //4
            Console.Clear();
            _InventoryData.Invoke(Vehicles, _Inputs);

            Console.ReadKey();
        }
    }
}
