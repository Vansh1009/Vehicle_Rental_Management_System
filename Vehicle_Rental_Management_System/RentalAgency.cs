using System;

public class RentalAgency
{
    // Array to store fleet of vehicles
    private Vehicle[] Fleet;
    // Total revenue earned by the rental agency
    private double TotalRevenue;

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 0;
    }

    // Method to add vehicle to the fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    // Method to remove vehicle from the fleet
    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            RemoveVehicle(index);
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    // Method to display total revenue
    public void DisplayTotalRevenue()
    {
        Console.WriteLine($"Total Revenue: {TotalRevenue:C}");
    }
}
