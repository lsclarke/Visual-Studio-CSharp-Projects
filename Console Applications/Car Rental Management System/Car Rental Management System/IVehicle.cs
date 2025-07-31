using System;
using System.Runtime.ConstrainedExecution;
using System.Collections;
using System.Collections.Generic;

public interface IVehicle
{
    //Methods to sucessfully create a vehicle in the system for renters to choose from
    string Make { set; get; }

    string Model { set; get; }

    long Year { set; get; }

    int Miles_Per_Gallon { set; get; }

    long Millage { set; get; }

    long Vehicle_Identification_Number { set; get; }

    double Price { set; get; }
}
