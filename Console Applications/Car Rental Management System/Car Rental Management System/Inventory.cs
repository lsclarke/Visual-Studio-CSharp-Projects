using System;
using System.Diagnostics;
using System.Reflection;


public class Inventory
{
    /// <summary>
    /// The Inventory class is responsible for keeping track of the collection of all the vehicles within the system! The class has 2 constructors that can be called on in the main method.
    /// this allows the user to see the data for each vehicle, the car number, millage, VIN, etc. I placed them in a dictonary to better structure and organize the data for when needing to be retrieved
    /// or called on for manipulation.
    /// </summary>
    private static int _num = 0;
    private static int _num2 = 0;

    public struct InventoryInputs()
    {
        public int DaysNumber = 0;
        public int CarNumber = 0;
        public double TotalCost = 0;
    }

    public Inventory()
    {

    }

    public Inventory(Dictionary<int, Car> dictionary)
    {
        //Inventory Data for the Rental Car System

        //SUVs
        Car SUV1 = new Car(1, "Honda", "Pilot", 2006, 128, 40670, 348492525892, 105.00);
        Car SUV2 = new Car(1, "Chevrolet", "Suburban LT", 2025, 103, 35679, 456637563544, 124.00);
        Car SUV3 = new Car(1, "Toyota", "RAV4 XLE 4D Sport Utility", 2025, 133, 65787, 3272334346734, 118.00);
        Car SUV4 = new Car(1, "Mazda", "CX-50", 2025, 130, 47766, 12325356465, 145.00);
        Car SUV5 = new Car(1, "Kia", "Sportage\r\nEX", 2025, 142, 23000, 7864756832334, 156.00);

        //Sedans
        Car Sedan1 = new Car(2, "Subaru ", "WRX", 2025, 131, 41445, 7563234522345, 175.00);
        Car Sedan2 = new Car(2, "Hyundai", "Sonata", 2024, 172, 35112, 9745245234451, 128.00);
        Car Sedan3 = new Car(2, "Nissan", "Versa", 2024, 121, 61273, 3272333414346734, 182.00);


        //Trucks
        Car Truck1 = new Car(3, "Ford", "Maverick", 2024, 116, 74866, 75733436425138, 165.00);
        Car Truck2 = new Car(3, "RAM", "1500", 2025, 175, 65877, 25363656343576, 163.00);

        //SUVs
        dictionary.Add(1, SUV1);
        dictionary.Add(2, SUV2);
        dictionary.Add(3, SUV3);
        dictionary.Add(4, SUV4);
        dictionary.Add(5, SUV5);

        //Sedans
        dictionary.Add(6, Sedan1);
        dictionary.Add(7, Sedan2);
        dictionary.Add(8, Sedan3);

        //Trucks
        dictionary.Add(9, Truck1);
        dictionary.Add(10, Truck2);

    }

    public delegate void DisplayInventoryData(Dictionary<int, Car> dictionary, InventoryInputs inventoryinputs );

    /// <summary>
    /// Responsible for displaying all the details for each individual Car in the dictionary
    /// </summary>

    public void DisplayCarDetails(Dictionary<int, Car> dictionary, InventoryInputs inventoryinputs)
    {
        if (inventoryinputs.CarNumber < 1)
        {
            foreach (var item in dictionary)
            {
                _num++;
                Console.WriteLine($"----------Car No.{_num} Details----------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Type:: {item.Value.result}, Make:: {item.Value.Make}, Model:: {item.Value.Model}");
                Console.WriteLine($"Year:: {item.Value.Year}, Miles Per Gallon:: {item.Value.Miles_Per_Gallon}, Millage:: {item.Value.Millage}");
                Console.WriteLine($"Vehicle Identification Number:: {item.Value.Vehicle_Identification_Number}");
                Console.WriteLine($"Price:: ${item.Value.Price}/Day");
                Console.WriteLine("-----------------------------------\n");
            }
        }
        else
        {
            foreach (var item in dictionary)
            {
                _num2++;
                if (_num2 == inventoryinputs.CarNumber)
                {
                    Console.WriteLine($"----THANK YOU FOR YOUR SELECTION----\n");
                    Console.WriteLine($"----------Car No.{_num2} Details----------");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Type:: {item.Value.result}, Make:: {item.Value.Make}, Model:: {item.Value.Model}");
                    Console.WriteLine($"Year:: {item.Value.Year}, Miles Per Gallon:: {item.Value.Miles_Per_Gallon}, Millage:: {item.Value.Millage}");
                    Console.WriteLine($"Vehicle Identification Number:: {item.Value.Vehicle_Identification_Number}");
                    Console.WriteLine($"Price:: ${item.Value.Price}/Day");
                    Console.WriteLine("-----------------------------------\n");
                    Console.WriteLine($"Rental Days: {inventoryinputs.DaysNumber}");
                    Console.WriteLine($"Total cost: ${inventoryinputs.TotalCost = (item.Value.Price * inventoryinputs.DaysNumber)}");
                }
            }
        }
    } 
}