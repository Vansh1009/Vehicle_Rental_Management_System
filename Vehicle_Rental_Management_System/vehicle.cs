﻿using System;

public class Vehicle
{
    // Properties
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public int Year { get; private set; }
    public double RentalPrice { get; private set; }

    // Constructor
    public Vehicle(string model, string manufacturer, int year, double rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Rental Price: {RentalPrice:C}");
    }
}
