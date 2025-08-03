using CarRentalManagementProject.Car_Resource;
using CarRentalManagementProject.Product;
using CarRentalManagementProject.Rental_Inventory;
using System;
using System.Reflection;
using static CarRentalManagementProject.Product.Car.Interior;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRentalManagementProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Car Dictionaries
            var suvDictionary = new Dictionary<int, SUV>();
            var sedanDictionary = new Dictionary<int, Sedan>();
            var truckDictionary = new Dictionary<int, Truck>();

            //Car Inventory instances
            var suvInventory = new Inventory<Dictionary<int, SUV>>();
            var sedanInventory = new Inventory<Dictionary<int, Sedan>>(); 
            var truckInventory = new Inventory<Dictionary<int, Truck>>();


            // Car Rental System Prompts Below//
            //Prompt 1
            Console.WriteLine("Car Rental Management System\n");

            Console.Write("Please enter the number of days you wish to rent one of our vehicles: ");
            int DaysNumber = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the car tpye you wish to rent \n [SUV, Sedan, Truck] \nType the name of one of the options provide: ");
            string typeSelectionInput = Console.ReadLine();

            Console.Clear();

            //Checks if string equals one of the selections
            if (typeSelectionInput.Equals("SUV", StringComparison.OrdinalIgnoreCase))
                suvInventory.GetAccessAll_SUVData(suvDictionary);

            if (typeSelectionInput.Equals("Sedan", StringComparison.OrdinalIgnoreCase))
                sedanInventory.GetAccessAll_SedanData(sedanDictionary);

            if (typeSelectionInput.Equals("Truck", StringComparison.OrdinalIgnoreCase))
                sedanInventory.GetAccessAll_TruckData(truckDictionary);

            //Car Id selection prompt
            Console.Write("\nEnter the Car ID number you wish to rent for this period: ");
            int idSelection = int.Parse(Console.ReadLine());

            if (typeSelectionInput.Equals("SUV", StringComparison.OrdinalIgnoreCase))
                suvInventory.GetAccessSingle_SUVData(suvInventory.GetAccessAll_SUVData(suvDictionary), idSelection, DaysNumber);

            if (typeSelectionInput.Equals("Sedan", StringComparison.OrdinalIgnoreCase))
                sedanInventory.GetAccessSingle_SedanData(sedanInventory.GetAccessAll_SedanData(sedanDictionary), idSelection, DaysNumber);

            if (typeSelectionInput.Equals("Truck", StringComparison.OrdinalIgnoreCase))
                truckInventory.GetAccessSingle_TruckData(truckInventory.GetAccessAll_TruckData(truckDictionary), idSelection, DaysNumber);


            Console.Write("\nDo you accept this purchase? (Y / N) ");
            char characterSelection = char.Parse(Console.ReadLine());

            if (characterSelection == 'Y' || characterSelection == 'y')
            {
                Console.Write("\nConmfirmed, Thank you for your purchase!!!"); 
                Console.Read();
                Console.WriteLine("Late fees may apply please return vehicle before deadline to avoid incrusion up to or more than $15!!!");
            }
            else
            {
                Console.Write("\nUnderstood, Thank you for your time and we hope to see you again, have a great day!");
                Console.ReadKey();
                Console.WriteLine("System Shutdown Complete!");
            }
                Console.ReadKey();
        }

        public string s { get; private set; }
    }
}
