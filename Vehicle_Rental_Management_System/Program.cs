using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Car car = new Car("Civic", "Honda", 2022, 50.0, 5, "Petrol", "Automatic", false);
        Truck truck = new Truck("F150", "Ford", 2020, 100.0, 2.5, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 30.0, 1000, "Petrol", true);

        RentalAgency agency = new RentalAgency(10);
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        Console.WriteLine("Available Vehicles:");
        car.DisplayDetails();
        truck.DisplayDetails();
        motorcycle.DisplayDetails();

        agency.RentVehicle(0);
        agency.DisplayTotalRevenue();
    }
}
