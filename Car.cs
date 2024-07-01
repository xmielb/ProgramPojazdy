using System;

public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsConvertible { get; set; }

    public Car(string make, string model, int year, bool isConvertible)
    {
        Make = make;
        Model = model;
        Year = year;
        IsConvertible = isConvertible;
    }

    public void Start()
    {
        Console.WriteLine($"{Make} {Model} ({Year}) uruchomiony.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} ({Year}) zatrzymany.");
    }

    public void OpenRoof()
    {
        if (IsConvertible)
        {
            Console.WriteLine($"Dach samochodu {Make} {Model} został otwarty.");
        }
        else
        {
            Console.WriteLine($"Samochód {Make} {Model} nie jest kabrioletem.");
        }
    }
}
