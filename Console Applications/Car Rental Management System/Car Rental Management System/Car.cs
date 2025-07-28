using System;
using System.Xml.Linq;

public class Car : Vehicle
{
    /// <summary>
    /// The Car class is responsible for creating all Car withing the system. By implementing the Vehicle interface
    /// this allows for the car to implement their own characteristics of the vehicle in a much more affective way
    /// </summary>

    public enum Type { SUV = 1, Sedan, Truck}
    public Type type;
    private static int num = 1;
	public Car()
	{
	}
    
    //Car Object
    public Car(Type clasification, string manufacturer, string name, long year, int MPG, long millage, long VIN, double cost)
    {
        type = clasification;
        Make = manufacturer;
        Model = name;
        Year = year;
        Miles_Per_Gallon = MPG;
        Millage = millage;
        Vehicle_Identification_Number = VIN;
        Price = cost;

    }

    public string Make { set; get; }

    public string Model { set; get; }

    public long Year { set; get; }

    public int Miles_Per_Gallon { set; get; }

    public long Millage { set; get; }

    public long Vehicle_Identification_Number { set; get; }

    public double Price { set; get; }

}
