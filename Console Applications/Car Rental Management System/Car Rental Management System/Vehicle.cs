using System;
using System.Runtime.ConstrainedExecution;
using System.Collections;
using System.Collections.Generic;

public interface Vehicle
{
    //Methods to sucessfully create a vehicle in the system for renters to choose from
    public string Make { set; get; }

    public string Model { set; get; }

    public long Year { set; get; }

    public int Miles_Per_Gallon { set; get; }

    public long Millage { set; get; }

    public long Vehicle_Identification_Number { set; get; }

    public double Price { set; get; }
}
