using System;

public class Bus : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int PassengerCapacity { get; set; }

    public Bus(string make, string model, int year, int passengerCapacity)
    {
        Make = make;
        Model = model;
        Year = year;
        PassengerCapacity = passengerCapacity;
    }

    public void Start()
    {
        Console.WriteLine($"{Make} {Model} ({Year}) uruchomiony.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} ({Year}) zatrzymany.");
    }

    public void LoadPassengers(int passengers)
    {
        if (passengers <= PassengerCapacity)
        {
            Console.WriteLine($"{passengers} pasażerów zostało załadowanych do autobusu {Make} {Model}.");
        }
        else
        {
            Console.WriteLine($"Zbyt wielu pasażerów. Autobus {Make} {Model} może przewozić tylko {PassengerCapacity} pasażerów.");
        }
    }
}
