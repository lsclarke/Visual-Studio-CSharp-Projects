using CarRentalManagementProject.Car_Resource;
using CarRentalManagementProject.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementProject.Rental_Inventory
{
    internal class Inventory<T>
    {
        private T _content;
        private int _index = 0;

        public Inventory()
        {

        }

        public Inventory(T content)
        {
            _content = content;
        }

        public Dictionary<int, SUV> GetAccessAll_SUVData(Dictionary<int, SUV> dictionary)
        {
            SUV car1 = new SUV("Honda", "Pilot", 2006, 128, 40670, 348492525892, 105.00, 1, 0);
            SUV car2 = new SUV("Chevrolet", "Suburban LT", 2025, 103, 35679, 456637563544, 124.00, 2, 2);
            SUV car3 = new SUV("Toyota", "RAV4 XLE 4D Sport Utility", 2025, 133, 65787, 3272334346734, 118.00, 2, 3);
            SUV car4 = new SUV("Mazda", "CX-50", 2025, 130, 47766, 12325356465, 145.00, 2, 1);
            SUV car5 = new SUV("Kia", "Sportage EX", 2025, 142, 23000, 7864756832334, 156.00, 1, 3);

            dictionary = new Dictionary<int, SUV>();
            dictionary.Add(1, car1);
            dictionary.Add(2, car2);
            dictionary.Add(3, car3);
            dictionary.Add(4, car4);
            dictionary.Add(5, car5);

            return dictionary;
        }

        public Dictionary<int, Sedan> GetAccessAll_SedanData(Dictionary<int, Sedan> dictionary)
        {
            Sedan car1 = new Sedan("Subaru ", "WRX", 2025, 131, 41445, 7563234522345, 175.00,2,3);
            Sedan car2 = new Sedan("Hyundai", "Sonata", 2024, 172, 35112, 9745245234451, 128.00,1,4);
            Sedan car3 = new Sedan("Nissan", "Versa", 2024, 121, 61273, 3272333414346734, 182.00, 1, 1);

            dictionary = new Dictionary<int, Sedan>();
            dictionary.Add(1, car1);
            dictionary.Add(2, car2);
            dictionary.Add(3, car3);

            return dictionary;
        }

        public Dictionary<int, Truck> GetAccessAll_TruckData(Dictionary<int, Truck> dictionary)
        {

            Truck car1 = new Truck("Ford", "Maverick", 2024, 116, 74866, 75733436425138, 165.00, 2, 3);
            Truck car2 = new Truck("RAM", "1500", 2025, 175, 65877, 25363656343576, 163.00, 1, 4);

            dictionary = new Dictionary<int, Truck>();
            dictionary.Add(1, car1);
            dictionary.Add(2, car2);

            return dictionary;
        }

        public  Dictionary<int, SUV> GetAccessSingle_SUVData(Dictionary<int, SUV> dictionary, int input, int days)
        {
            Console.Clear();
            int num = 0;
            if (dictionary.ContainsKey(input))
            {
                foreach (var items in dictionary)
                {
                    num++;
                    if (input == items.Key)
                    {
                        items.Value.UpdateId(input);
                        items.Value.Display();

                        string output = String.Format("{0:0.00}", items.Value.CalculateTotalPrice(days, items.Value.Price)); 
                        Console.WriteLine($"  **  Rent days: #{days}  **");
                        Console.WriteLine($"  **  Total cost: ${output}  **");

                    }
                }
            }  
                return dictionary;
        }

        public Dictionary<int, Sedan> GetAccessSingle_SedanData(Dictionary<int, Sedan> dictionary, int input, int days)
        {
            Console.Clear();
            int num = 0;
            if (dictionary.ContainsKey(input))
            {
                foreach (var items in dictionary)
                {
                    num++;
                    if (input == items.Key)
                    {
                        items.Value.UpdateId(input);
                        items.Value.Display();

                        string output = String.Format("{0:0.00}", items.Value.CalculateTotalPrice(days, items.Value.Price));
                        Console.WriteLine($"  **  Rent days: #{days}  **");
                        Console.WriteLine($"  **  Total cost: ${output}  **");

                    }
                }
            }
            return dictionary;
        }


        public Dictionary<int, Truck> GetAccessSingle_TruckData(Dictionary<int, Truck> dictionary, int input, int days)
        {
            Console.Clear();
            int num = 0;
            if (dictionary.ContainsKey(input))
            {
                foreach (var items in dictionary)
                {
                    num++;
                    if (input == items.Key)
                    {
                        items.Value.UpdateId(input);
                        items.Value.Display();

                        string output = String.Format("{0:0.00}", items.Value.CalculateTotalPrice(days, items.Value.Price));
                        Console.WriteLine($"  **  Rent days: #{days}  **");
                        Console.WriteLine($"  **  Total cost: ${output}  **");

                    }
                }
            }
            return dictionary;
        }
    }
}
