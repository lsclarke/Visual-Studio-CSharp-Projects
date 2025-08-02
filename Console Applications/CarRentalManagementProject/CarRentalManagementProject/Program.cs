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
            SUV suv1 = new SUV("Honda", "Pilot", 2006, 128, 40670, 348492525892, 105.00,2,0);
            suv1.Display();

            SUV suv2 = new SUV("Chevrolet", "Suburban LT", 2025, 103, 35679, 456637563544, 124.00,1,0);
            suv2.Display();


        }
    }
}
