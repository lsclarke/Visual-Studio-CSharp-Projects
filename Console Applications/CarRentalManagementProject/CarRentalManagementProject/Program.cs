using CarRentalManagementProject.Product;
using CarRentalManagementProject.Rental_Inventory;
using System;
using System.Reflection;
using static CarRentalManagementProject.Product.Car.Interior;

namespace CarRentalManagementProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //SUVs
            List<SUV> suvList = new List<SUV>();
            SUV car1 = new SUV("Honda", "Pilot", 2006, 128, 40670, 348492525892, 105.00,1,0);
            SUV car2 = new SUV("Chevrolet", "Suburban LT", 2025, 103, 35679, 456637563544, 124.00,2,2);
            SUV car3 = new SUV("Toyota", "RAV4 XLE 4D Sport Utility", 2025, 133, 65787, 3272334346734, 118.00,2,0);
            SUV car4 = new SUV("Mazda", "CX-50", 2025, 130, 47766, 12325356465, 145.00,3,2);
            SUV car5 = new SUV("Kia", "Sportage EX", 2025, 142, 23000, 7864756832334, 156.00,3,4);

            suvList.Add(car1);
            suvList.Add(car2);
            suvList.Add(car3);
            suvList.Add(car4);
            suvList.Add(car5);

            var suvInventory = new Inventory<SUV>();

            suvInventory.Display(suvList);


        }
    }
}
