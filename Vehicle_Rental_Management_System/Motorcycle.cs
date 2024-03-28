using System;

public class Motorcycle : Vehicle
{
    // Additional properties
    public int EngineCapacity { get; private set; }
    public string FuelType { get; private set; }
    public bool HasFairing { get; private set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice,
                      int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override method to display motorcycle details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity} cc");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}");
    }
}
using System;

public class Class1
{
	public Class1()
	{
	}
}
