using CarRentalManagementProject.Product;
using CarRentalManagementProject.Rental_Inventory;
using System;
using System.Reflection;
using static CarRentalManagementProject.Product.Car.Interior;

namespace CarRentalManagementProject
{
    internal class Program
    {
        public enum Colors { black, white }
        
        static void Main(string[] args)
        {
            SUV car1 = new SUV("Honda", "Pilot", 2006, 128, 40670, 348492525892, 105.00, 8, 2, 1, true, true, true, 1, 4, 95, true, true, true, true, true);
            SUV car2 = new SUV("Chevrolet", "Suburban LT", 2025, 103, 35679, 456637563544, 124.00, 6, 3, 2, true, true, false, 1, 4, 73, false, true, false, true, true);

            List<SUV> suvList = new List<SUV>();
            
            suvList.Add(car1);
            suvList.Add((car2));
            
            var inventorySUV = new Inventory<SUV>();
          
            
        }
    }
}
