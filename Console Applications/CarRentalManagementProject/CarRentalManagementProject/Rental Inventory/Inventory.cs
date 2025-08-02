using CarRentalManagementProject.Product;
using System;
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

        public Inventory()
        {

        }

        public Inventory(T content)
        {
            _content = content;
        }

        public void Display(List<T> value)
        {
            foreach (var item in value)
            {
                Console.WriteLine(value);
            }
        }

        public void Display(List<SUV> value)
        {
            foreach (var item in value)
            {
                item.Display();
            }
        }

    }
}
